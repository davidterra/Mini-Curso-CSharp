namespace Exemplo3
{
    public class Cliente
    {
        //public Cliente()
        //{

        //}
        public Cliente(int id, string nome, string cidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cidade = cidade;
        }
        public int Id { get;  private set; }
        public string Nome { get; private set; }
        public string Cidade { get; private set; }
    }
}
