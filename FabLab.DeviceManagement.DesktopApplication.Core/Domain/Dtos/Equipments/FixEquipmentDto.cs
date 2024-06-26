﻿using FabLab.DeviceManagement.DesktopApplication.Core.Domain.Models.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabLab.DeviceManagement.DesktopApplication.Core.Domain.Dtos.Equipments
{
    public class FixEquipmentDto
    {
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public DateTime YearOfSupply { get; set; }
        public string CodeOfManager { get; set; }
        public EStatus Status { get; set; }
        public string LocationId { get; set; }
        public string SupplierName { get; set; }
        public string EquipmentTypeId { get; set; }

        public FixEquipmentDto(string equipmentId, string equipmentName, DateTime yearOfSupply, string codeOfManager, EStatus status, string locationId, string supplierName, string equipmentTypeId)
        {
            EquipmentId = equipmentId;
            EquipmentName = equipmentName;
            YearOfSupply = yearOfSupply;
            CodeOfManager = codeOfManager;
            Status = status;
            LocationId = locationId;
            SupplierName = supplierName;
            EquipmentTypeId = equipmentTypeId;

        }
    }
}
