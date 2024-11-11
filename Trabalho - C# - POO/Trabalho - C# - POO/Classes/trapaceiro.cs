namespace trabalhoRPG.Classes{
    class trapaceiro1 : ladrao1{
        protected override bool trapaca(){
            return enganar();
        }

        protected bool enganar(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50-stealth){
                Console.WriteLine("O inimigo não te achou, você desviou do ataque!");
                facada();
                return true;
            }
            return false;
        }
    }
}