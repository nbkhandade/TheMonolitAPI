using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TheMonolit.API.Models;

namespace TheMonolit.API.Data
{
    public static class Seed
    {
        public static void SeedData(DataContext context){

            if(!context.FundDataValues.Any()){
                var fundData = System.IO.File.ReadAllText("Data/FundData.json");
                var data = JsonConvert.DeserializeObject<List<FundDataValue>>(fundData);
                foreach(var d in data)
                {
                    context.FundDataValues.Add(d);
                }
                context.SaveChanges();
            }
        }
    }
}