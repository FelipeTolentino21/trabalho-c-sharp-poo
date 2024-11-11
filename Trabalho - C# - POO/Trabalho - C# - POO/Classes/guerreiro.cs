namespace trabalhoRPG.Classes{
    class guerreiro1 : jogador1{

        protected static int defesa = 5;
        protected static int forca = 5;
        protected override int atacar(){
            return espadada();
        }

        protected virtual int espadada(){
            int valor = valorDano + forca;
            if (estamina<=0){
                estamina = 0;
                Console.WriteLine("Você está sem estamina!");
                valor = 0;
                return valor;
            }
            estamina -= 5;
            return valor;
        }

        protected override bool desviar(){
            return usarEscudo();
        }

        protected virtual bool usarEscudo(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50-forca){
                Console.WriteLine("Você desviou!");
                return true;
            }
            return false;
        }
    }
}