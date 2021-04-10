using System;
using System.Collections.Generic;
using System.Text;

namespace Tp2
{
    class client
    {
        private string nom;
        private string prénom;
        private int age;


        public client()
        {
        }

        public client( string nom,string prénom, int age )
        {
            this.Nom = nom;
            this.Prénom = prénom;
            this.Age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prénom { get => prénom; set => prénom = value; }
        public int Age { get => age; set => age = value; }

    }
}
