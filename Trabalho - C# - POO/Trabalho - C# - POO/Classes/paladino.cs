namespace trabalhoRPG.Classes{
    class paladino1 :guerreiro1{
        protected override bool usarEscudo(){
            return bloqueio();
        }

        protected virtual bool bloqueio(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50-(forca*2)){
                Console.WriteLine("Você desviou!");
                return true;
            }
            return false;
        }
    }
}