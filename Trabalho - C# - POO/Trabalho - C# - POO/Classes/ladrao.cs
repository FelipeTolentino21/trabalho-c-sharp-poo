namespace trabalhoRPG.Classes{
    class ladrao1 : jogador1{

        protected static int stealth = 20;
        protected override int atacar(){
            return facada();
        }

        protected virtual int facada(){
            int valor = valorDano;

            Random random = new Random();
            int valorCritico = random.Next(0,100);

            if (estamina<=0){
                estamina = 0;
                Console.WriteLine("Você está sem estamina!");
                valor = 0;
                return valor;
            } else if (valorCritico>=25) {
                estamina -= 5;
                valor *= 2;
                return valor;
            }
            estamina -= 5;
            return valor;
        }

        protected override bool desviar(){
            return trapaca();
        }

        protected virtual bool trapaca(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50-stealth){
                Console.WriteLine("O inimigo não te achou, você desviou do ataque!");
                return true;
            }
            return false;
        }
    }
}