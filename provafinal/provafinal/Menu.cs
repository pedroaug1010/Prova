class Menu
{
    public string Nome { get; set; }
    public int Senha { get; set; }
    public int Id { get; set; }
    public float Data { get; set; }


    public Menu(string nome, int senha, int id, float data)
    {
        Nome = nome;
        Senha = senha;
        Id = id;
        Data = data;
    }

}