namespace trabalhoRPG.Classes{
    abstract class jogador1{
        protected static int vidaMax = 20;
        protected static int vida = vidaMax;
        protected static int estaminaMax = 40;
        protected static int estamina = estaminaMax;
        protected static int valorDano = 5;

        //Fazer com que classes herdem os atributos 1 e 2 para modificá-los ao subir de nível
        //Usar get e set para fazer isso (ver vídeo aula)
        //https://www.youtube.com/watch?v=tqpWrhU4WmM
        protected static int atributo1 = 5;
        protected static int atributo2 = 5;
        protected abstract int atacar();

        protected virtual bool desviar(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50){
                Console.WriteLine("Você desviou!");
                return true;
            }
            return false;
        }

        protected virtual void curar(){
            vida += 10;
            if(vida>vidaMax){
                vida = vidaMax;
            }
        }
    }
}