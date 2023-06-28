using System.Linq.Expressions;
using System.Reflection;

namespace Atena.Domain.Core.Tools
{
    public static class InstanceCreator
    {
        static public object Create<TArg, TClass>(TArg arg)
        {
            var constructor = typeof(TClass).GetConstructor(new Type[] { typeof(TArg) });
            var parameter = Expression.Parameter(typeof(TArg), "p");
            var creatorExpression = Expression.Lambda<Func<TArg, TClass>>(
                Expression.New(constructor, new Expression[] { parameter }), parameter);
            var func = creatorExpression.Compile();

            var creator = func;

            return creator(arg);
        }

        public delegate T Creator<T>(params object[] args);

        public static Creator<T> GetCreator<T>(params object[] args)
        {
            ConstructorInfo[] constructors = typeof(T).GetConstructors();

            if (constructors.Length >= 0)
            {
                ConstructorInfo constructor = constructors.Where(c => c.GetParameters().Length == args.Length).FirstOrDefault();

                ParameterInfo[] paramsInfo = constructor.GetParameters();

                if (paramsInfo.Length >= 0)
                {
                    ParameterExpression param = Expression.Parameter(typeof(object[]), "args");

                    Expression[] argsExpressions = new Expression[paramsInfo.Length];

                    for (int i = 0; i < paramsInfo.Length; i++)
                    {
                        Expression index = Expression.Constant(i);
                        Type paramType = paramsInfo[i].ParameterType;
                        Expression paramAcessoExp = Expression.ArrayIndex(param, index);
                        Expression paramCastExp = Expression.Convert(paramAcessoExp, paramType);
                        argsExpressions[i] = paramCastExp;
                    }

                    NewExpression newExpression = Expression.New(constructor, argsExpressions);

                    LambdaExpression lambda = Expression.Lambda(typeof(Creator<T>), newExpression, param);

                    Creator<T> compiled = (Creator<T>)lambda.Compile();

                    return compiled;
                }
            }

            return null;
        }

        public static T CreateInstanceUsingLambdaExpression<T>(params object[] args)
        {
            Creator<T> createdActivator = GetCreator<T>(args);
            return createdActivator(args);
        }
    }
}
