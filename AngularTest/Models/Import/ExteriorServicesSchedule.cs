using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularTest.Models.Import
{
    public class ExteriorServicesSchedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int ScheduleID { get; set; }
        public string Request_Type { get; set; }
        public string Pre_Tax_Client_Price { get; set; }
        public int Sep_x_per_wk { get; set; }
        public string Customer { get; set; }
        public decimal May_x_per_wk { get; set; }
        public string Store { get; set; }
        public decimal Feb_x_per_wk { get; set; }
        public string Provider_Cost { get; set; }
        public string Post_Tax_Client_Price { get; set; }
        public decimal Jun_x_per_wk { get; set; }
        public string Work_Type { get; set; }
        public decimal Dec_x_per_wk { get; set; }
        public decimal Nov_x_per_wk { get; set; }
        public decimal Month10 { get; set; }
        public string ID { get; set; }
        public decimal Jul_x_per_wk { get; set; }
        public decimal Month5 { get; set; }
        public decimal Month4 { get; set; }
        public decimal Month7 { get; set; }
        public decimal Month6 { get; set; }
        //public string __invalid_name__Store.City { get; set; }
        public decimal Month1 { get; set; }
        public decimal Month3 { get; set; }
        public decimal Month2 { get; set; }
        public string Vendor { get; set; }
        public decimal Times_Per_Week { get; set; }
        public decimal Month9 { get; set; }
        public decimal Month8 { get; set; }
        //public string __invalid_name__Store.Zip { get; set; }
        public decimal Mar_x_per_wk { get; set; }
        public decimal Month11 { get; set; }
        public string Service_Day { get; set; }
        public decimal Month12 { get; set; }
        public decimal? Tax_Rate { get; set; }
        public decimal Oct_x_per_wk { get; set; }
        public string State { get; set; }
        //public string __invalid_name__Store.Address { get; set; }
        public decimal Apr_x_per_wk { get; set; }
        public decimal Aug_x_per_wk { get; set; }
        public string Request_Code { get; set; }
        public string Active_Status { get; set; }
    }
}
