﻿
using Atena.Domain.Commands.Address.City;

namespace Atena.Domain.Validations.Address.City
{
    public class AddCityValidation : CityValidation<AddCityCommand>
    {
        public AddCityValidation() 
        {
            Validate();
        }
    }
}