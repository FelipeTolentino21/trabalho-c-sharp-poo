namespace trabalhoRPG.Classes{
    class atirador1 : arqueiro1{
        protected override int atirar(){
            return bomba();
        }

        protected virtual int bomba(){
            int valor = valorDano + (destreza*2);
            if (estamina<=0){
                estamina = 0;
                Console.WriteLine("Você está sem estamina!");
                valor = 0;
                return valor;
            }
            estamina -= 5;
            return valor;
        }
    }
}