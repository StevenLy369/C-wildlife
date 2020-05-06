namespace Models{

    public class Animal {

        private string _Name;
        private string _Breed;

        private string _Color;

        private string _Species;
        private int _Age;

        public Animal(string name, string breed, string color, string species, int age){

            _Name = name;
            _Breed = breed;
            _Color = color;
            _Species = species;
            _Age = age;
        }

        public void SetAge(int newAge){
            _Age = newAge;
        }

        public int GetAge(){
            return _Age;
        }

        public string GetName(){
            return _Name;
        }
        public string GetBreed(){
            return _Breed;
        }
        public string GetColor(){
            return _Color;
        }

        public static string MakePoopNoise(string sound){
            return "Poopy poopy " + sound;
        }

        






    }



}