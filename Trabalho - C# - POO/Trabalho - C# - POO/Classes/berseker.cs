namespace trabalhoRPG.Classes{
    class berserker1 :guerreiro1{
        protected override int espadada(){
            return furia();
        }

        protected virtual int furia(){
            int valor = valorDano + (forca*2);
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