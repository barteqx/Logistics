﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Logistics.Domain.Model.Delivery
{
    public class Delivery
    {
        public int Id { get; set; }

        public bool Accepted { get; set; }

        public string From { get; set; }

        public List<DeliveryRecord> DeliveryRecords { get; set; }

        public DateTime Date { get; set; }

		public void AddDeliveryRecord(DeliveryRecord DeliveryRecord)
		{
			DeliveryRecords.Add(DeliveryRecord);
		}

		public void DeleteDeliveryRecord(int Id)
		{
            foreach (var item in DeliveryRecords)
                if (item.Id == Id)
                    DeliveryRecords.Remove(item);
		}

        
    }
}
