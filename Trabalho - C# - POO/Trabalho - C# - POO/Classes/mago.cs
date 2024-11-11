namespace trabalhoRPG.Classes{
    class mago1 : jogador1{

        protected static int manaMax = 80;

        protected int mana = manaMax;

        protected static int conhecimento = 5;
        protected override int atacar(){
            return usarMagia();
        }

        protected virtual int usarMagia(){
            int valor = valorDano + conhecimento;
            if(mana<=0 && estamina<=0){
                estamina = 0;
                mana = 0;
                Console.WriteLine("Você está sem mana e sem estamina!");
                valor = 0;
                return valor;
            } else if (mana<=0){
                mana = 0;
                Console.WriteLine("Você está sem mana!");
                valor = 0;
                return valor;
            } else if (estamina<=0){
                estamina = 0;
                Console.WriteLine("Você está sem estamina!");
                valor = 0;
                return valor;
            }
            mana -= 10;
            estamina -= 5;
            return valor;
        }
    }
}
