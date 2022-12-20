using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_Project
{
    public class Person {
        private uint holder_id, job_id, department_id;
        private string surname, name, lastname, path_to_photo, card_id;
        private bool status;


        // constructors
        public Person()
        {
            holder_id = 0; 
            job_id = 0; 
            department_id = 0;
            surname = "";
            name = "";
            lastname = "";
            path_to_photo = "";
            card_id = "";
        }
        public Person(uint holder_id, string card_id, uint job_id, uint department_id, string surname, string name, string lastname, string path_to_photo, bool status)
        {
            this.holder_id = holder_id;
            this.card_id = card_id;
            this.job_id = job_id;
            this.department_id = department_id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.path_to_photo = path_to_photo;
            this.status = status;
        }

        // getters ans setters
        public uint get_holder_id()
        {
            return holder_id;
        }
        public void set_holder_id(uint val)
        {
            holder_id = val;
        }

        public string get_card_id()
        {
            return card_id;
        }
        public void set_card_id(string val)
        {
            card_id = val;
        }

        public uint get_job_id()
        {
            return job_id;
        }
        public void set_job_id(uint val)
        {
            job_id = val;
        }

        public uint get_department_id()
        {
            return department_id;
        }
        public void set_department_id(uint val)
        {
            department_id = val;
        }

        public string get_surname()
        {
            return surname;
        }
        public void set_surname(string val)
        {
            surname = val;
        }

        public string get_name()
        {
            return name;
        }
        public void set_name(string val)
        {
            name = val;
        }

        public string get_lastname() {
            return lastname;
        }
        public void set_lastname(string val)
        {
            lastname = val;
        }
        
        public string get_path_to_photo()
        {
            return path_to_photo;
        }
        public void set_path_to_photo(string val)
        {
            path_to_photo = val;
        }

        public bool get_status()
        {
            return status;
        }
        public void set_status(bool val)
        {
            status = val;
        }
    }
}
