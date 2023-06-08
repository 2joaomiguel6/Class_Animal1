namespace ams_heranca_treeclass{
class Walks : Animais{
        public Walks(string id, string name) : base(id, name){
        }

        public virtual void Voar(){
            Console.WriteLine($"O {Name}, é uma ave que não voa.");
            Console.WriteLine($"O ID da pinguim é: {ID}");
            Console.WriteLine($"O nome da espécie é: {Name}");
        }
    }
}