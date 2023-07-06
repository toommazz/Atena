﻿using Atena.Domain.Interfaces.Commands;

namespace Atena.Domain.Commands.Address
{
    public class AddAddressCommand : AddressCommand, IAddCommand
    {

        public AddAddressCommand(
            Guid? id,
            Guid addressTypeId,
            string addressName,
            string number,
            string complement,
            string district,
            Guid cityId,
            Guid stateId,
            string zipCode,
            string reference,
            Guid clientId
                        
            ) : base(id, addressTypeId, addressName,number, complement,district,cityId, stateId, zipCode, reference, clientId) { }
        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
