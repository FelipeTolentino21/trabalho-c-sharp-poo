namespace trabalhoRPG.Classes{
    class inimigo1{

        protected static int vidaMaxInimigo = 20;
        protected int vidaInimigo = vidaMaxInimigo;

        protected virtual int danoInimigo(){
            return 5;
        }
    }
}