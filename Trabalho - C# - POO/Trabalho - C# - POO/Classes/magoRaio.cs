namespace trabalhoRPG.Classes{
    class magoRaio1 : mago1{
        protected override int  usarMagia(){
            return magiaRaio();
        }

        //Usar paralised para stunnar e dar dano (Usar onFire para dar dano contínuo)
        private int valorRaio = 3;

        private int magiaRaio(){
            int valor = valorDano + conhecimento + valorRaio;
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
