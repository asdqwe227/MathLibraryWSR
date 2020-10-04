using EmployeAccouting.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows;

namespace EmployeAccouting.Services
{
    class Saveses
    {
        private readonly string Path;
        
        public BindingList<Person> Load()
        {
            bool resultExists = File.Exists(Path);
            if(resultExists == false)
            {
                File.Create(Path);
                return new BindingList<Person>()
                {
                };
            }
            using (StreamReader reader = File.OpenText(Path))
            {
                string saveData = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Person>>(saveData);
            }
        }
        public void Save(BindingList<Person> list)
        {
            using (StreamWriter writer = File.CreateText(Path))
            {
                string Output = JsonConvert.SerializeObject(list);
                writer.Write(Output);
            }
        }
        public Saveses(string path)
        {
            Path = path;
        }
    }
}
