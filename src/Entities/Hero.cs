namespace rpg_friendly.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, int MP, int HP){
            this.Name = Name;
            this.Level = Level;
            this.MP = MP;
            this.HP = HP;

        }

        public Hero(){
            this.Name = "Davi Wendemberg";
            this.Level = 18;
            this.MP = 1000;
            this.HP = 10000;
        }

        public string Name;
        public int Level;

        public int Attack;
        
        public int MP;

        public int HP;

        public override string ToString(){
           return this.Name + "" + this.Level + "" + this.Attack;

        }

    }
}