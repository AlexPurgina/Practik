using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratep
{
    public class Test
    {
        public static bool SearchTestMaterial(string material)
        {
            Material material1 = BD.practik1282.Material.Where(x => x.Name_material.ToString().ToLower().Contains(material)).FirstOrDefault();
            if (material1 != null)  return true;
            else return false;
        }
        public static bool SearchTestOKEI(string okei)
        {
            OKEI oKEI = BD.practik1282.OKEI.Where(x => x.Name_unit.ToString().ToLower().Contains(okei)).FirstOrDefault();
            if (oKEI != null) return true;
            else return false;
        }
        public static bool SearchTestNomencloture(string nomencloture1)
        {
            Nomencloture nomencloture = BD.practik1282.Nomencloture.Where(x => x.Name_product.ToString().ToLower().Contains(nomencloture1)).FirstOrDefault();
            if (nomencloture != null) return true;
            else return false;
        }

        public static bool AutorizatingTest(string login, string password)
        {
            User user = BD.practik1282.User.Where(c => c.Login == login && c.Password == password).FirstOrDefault();
            if (user != null) return true;
            else return false;
        }
    }
}
