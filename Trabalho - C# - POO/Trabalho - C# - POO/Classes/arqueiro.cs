namespace trabalhoRPG.Classes{
    class arqueiro1 : jogador1{

        protected static int agilidade = 10;
        protected static int destreza = 5;

        protected override int atacar(){
            return atirar();
        }

        protected virtual int atirar(){
            int valor = valorDano + destreza;
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
            return esquiva();
        }

        private bool esquiva(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50-agilidade){
                Console.WriteLine("Você desviou!");
                return true;
            }
            return false;
        }
    }
}