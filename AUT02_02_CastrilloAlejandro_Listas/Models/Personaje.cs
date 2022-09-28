using System.ComponentModel.DataAnnotations;

namespace AUT02_02_CastrilloAlejandro_Listas.Models
{
    public class Personaje
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int NChildren { get; set; }

        public Personaje(int value1, string value2, string value3, int value4)
        {
            this.Id = value1;
            this.Name = value2;
            this.Family = value3;
            this.NChildren = value4;
        }

    }

}
