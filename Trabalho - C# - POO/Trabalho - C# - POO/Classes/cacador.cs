namespace trabalhoRPG.Classes{
    class cacador1 : arqueiro1{
        protected override bool desviar(){
            return esconderNasSombras();
        }

        protected virtual bool esconderNasSombras(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50-(destreza*2)){
                Console.WriteLine("Você desviou!");
                return true;
            }
            return false;
        }
    }
}