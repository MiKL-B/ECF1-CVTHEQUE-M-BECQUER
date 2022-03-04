using System;

namespace ECF1_CVTHEQUE_M_BECQUER
{
    public class Candidat
    {
        public string Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; } 
        public string Address1 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string SmartPhone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Profil { get; set; }
        public string Skill1 { get; set; }
        public string WebSite { get; set; }
        public string LinkedinProfil { get; set; }
        public string ViadeoProfil { get; set; }
        public string FacebookProfil { get; set; }
       
       
        public Candidat(string rowData)
        {

        
           // séparer les datas qui sont séparées par des point virgule
            string[] data = rowData.Split(';');
          
            //si un champs vaut NULL on affichera un vide
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == "NULL")
                {
                    data[i] = "  ";
                }

            }
            try{
                //séparation du jour, du mois et de l'année de la date de naissance
                string[] birth = data[4].Split('/');
                ////concaténation du jour, du mois et de l'année de la date de naissance
                DateTime birthDay = new DateTime(Convert.ToInt32(birth[2]), Convert.ToInt32(birth[1]), Convert.ToInt32(birth[0]));

                DateTime today = DateTime.Today;
                int age = today.Year - birthDay.Year;
                this.Age = age;
            }
            catch
            {

            }
     
            // parse data en propriété
            this.Id = data[0];
            this.LastName = data[1];
            this.FirstName = data[2];
            this.BirthDate = data[4];
            this.Address = data[5];
            this.Address1 = data[6];
            this.CodePostal = data[7];
            this.Ville = data[8];
            this.SmartPhone = data[9];
            this.Phone = data[10];
            this.Email = data[11];
            this.Profil = data[12];
            this.Skill1 = data[13];
            for (int i = 14; i <= 22; i++)
            {
                this.Skill1 += "\n" + data[i];
            };
            this.WebSite = data[23];
            this.LinkedinProfil = data[24];
            this.ViadeoProfil = data[25];
            this.FacebookProfil = data[26];

        }
      

    }
}
