namespace Legolas.Entity
{
    public class UsuariosEntity
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Master { get; set; }
        public bool Ativo { get; set; }
        public bool Engenhero { get; set; }
        public bool Administracao { get; set; }
    }
}
