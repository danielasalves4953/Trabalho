public class PerfilProfissional{
public string? FormacaoAcademica { get; set; }
public string? ExperienciaProfissional { get; set; }
public List<Habilidade>? Habilidades { get; set; }
public List<Competencia>? Competencias { get; set; }

public List<Competencia> listarCompetencias(){  //para listar competencias do usuário
      return this.Competencias!;
}
public List<Habilidade> listarHabilidade(){ 
    return this.Habilidades!; //para listar competencias do usuário
}

}