using System;

namespace ams_heranca_treeclass
{
    class Animais
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Animais(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}