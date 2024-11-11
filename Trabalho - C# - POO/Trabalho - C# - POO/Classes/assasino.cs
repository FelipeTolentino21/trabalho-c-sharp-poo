namespace trabalhoRPG.Classes{
    class assasino1 : ladrao1{
        protected override int facada(){
            return envenenar();
        }

        //Usar onFire para dar dano contínuo
        private int valorVeneno = 3;

        protected virtual int envenenar(){
            int valor = valorDano + valorVeneno;

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
    }
}