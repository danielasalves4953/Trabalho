public class Usuario{
public string? Nome { get; set; }
public string? Email {get; set; }
public string? Senha {get; set;}
public string? Idade {get; set; }
public PerfilProfissional? PerfilProfissionals {get; set;}
public List<AtividadeDesenvolvimentoPessoal>? atividadeDesenvolvimentoPessoal {get; set;}
public List<MetaObjetivos>? metaObjetivos {get; set;}
}