using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF1_CVTHEQUE_M_BECQUER
{
    public class Candidat
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int BirthDate { get; set; }
        public string Address { get; set; } 
        public string Address1 { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public int SmartPhone { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Profil { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public string Skill5 { get; set; }
        public string Skill6 { get; set; }
        public string Skill7 { get; set; }
        public string Skill8 { get; set; }
        public string Skill9 { get; set; }
        public string Skill10 { get; set; }

        public string WebSite { get; set; }
        public string LinkedinProfil { get; set; }
        public string ViadeoProfil { get; set; }
        public string FacebookProfil { get; set; }

        public Candidat(string rowData)
        {
            //séparer les datas qui sont séparées par des point virgule
            string[] data = rowData.Split(';');


            // parse data en propriété
            this.Id = Convert.ToInt32(data[0]);
            this.LastName = data[1];
            this.FirstName = data[2];
            //this.Age = Convert.ToInt32(data[3]);
            //this.BirthDate = Convert.ToInt32(data[4]);
            this.Address = data[5];
            this.Address1 = data[6];
            //this.CodePostal = Convert.ToInt32(data[7]);
            this.Ville = data[8];
            //this.SmartPhone = Convert.ToInt32(data[9]);
            //this.Phone = Convert.ToInt32(data[10]);
            this.Email = data[11];
            this.Profil = data[12];
            this.Skill1 = data[13];
            this.Skill2 = data[14];
            this.Skill3 = data[15];
            this.Skill4 = data[16];
            this.Skill5 = data[17];
            this.Skill6 = data[18];
            this.Skill7 = data[19];
            this.Skill8 = data[20];
            this.Skill9 = data[21];
            this.Skill10 = data[22];
            this.WebSite = data[23];
            this.LinkedinProfil = data[24];
            this.ViadeoProfil = data[25];
            this.FacebookProfil = data[26];

        }
      

    }
}
