public class Program
{

    static void Main(string[] args)
    {
        int? menu = 1;
        while (menu > 0)
        {
            Console.WriteLine("Escolha uma das opções abaixo... ");
            Console.WriteLine("1 Cadastro de usuário");
            Console.WriteLine("2 Cadastro de analise de mercado");
            Console.WriteLine("3 Cadastro contato de networking");
            Console.WriteLine("4 Cadastrar atividade de desenvolvimento pessoal");
            Console.WriteLine("5 Cadastro de metas e objetivos");
            Console.WriteLine("0 para sair");
            
            
            menu = int.Parse(Console.ReadLine()!);

            // CADASTRO DE USUARIO
            if (menu == 1)
            {
                Console.WriteLine("Bem-vindo ao cadastro de usuários!");

                Usuario novoUsuario = new Usuario();
                Console.WriteLine("Digite seu nome: ");
                novoUsuario.Nome = Console.ReadLine();
                Console.WriteLine("Digite seu email: ");
                novoUsuario.Email = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                novoUsuario.Senha = Console.ReadLine();
                Console.WriteLine("Digite sua idade: ");
                novoUsuario.Idade = Console.ReadLine();
                List<PerfilProfissional> perfilProfissionals = new List<PerfilProfissional>();
                List<MetaObjetivos> metaObjetivos = new List<MetaObjetivos>();
                List<AtividadeDesenvolvimentoPessoal> atividadeDesenvolvimentoPessoals = new List<AtividadeDesenvolvimentoPessoal>();
                Console.WriteLine("\nUsuário cadastrado com sucesso!");
                Console.WriteLine("Nome: " + novoUsuario.Nome);
                Console.WriteLine("Email: " + novoUsuario.Email);
                Console.WriteLine("Idade: " + novoUsuario.Idade);
                

                Console.WriteLine("Deseja cadastrar um Perfil profissional agora? 1 (Sim) - 0 (Não)");
                while (menu > 0)
                {
                    menu = int.Parse(Console.ReadLine()!);

                    // CADASTRO DE PERFIL PROFISSIONAL
                    if (menu == 1)
                    {
                        PerfilProfissional perfilProfissional = new PerfilProfissional();
                        Console.WriteLine("Digite sua formação academica:");
                        perfilProfissional.FormacaoAcademica = Console.ReadLine();
                        Console.WriteLine("Digite sua experiência profissional");
                        perfilProfissional.ExperienciaProfissional = Console.ReadLine();

                        List<Habilidade> habilidades = new List<Habilidade>();
                        List<Competencia> competencias = new List<Competencia>();

                      while (menu > 0) {
                        // habilidades
                        Habilidade habilidade = new Habilidade();
                        Console.WriteLine("nome da habilidade:");
                        habilidade.nome = Console.ReadLine();
                        Console.WriteLine("descrição da habilidade:");
                        habilidade.descricao = Console.ReadLine();
                        Console.WriteLine("tipo da habilidade:");
                        habilidade.tipo = Console.ReadLine();
                        habilidades.Add(habilidade);
                        perfilProfissional.Habilidades= habilidades; //fazer o mesmo em compencia


                        // competencias
                        Competencia competencia = new Competencia();
                        Console.WriteLine("nome da competencia:");
                        competencia.Nome = Console.ReadLine();
                        Console.WriteLine("descrição da competencia:");
                        competencia.Descricao = Console.ReadLine();
                        Console.WriteLine("aplicabilidade da competencia:");
                        competencia.Aplicabilidade = Console.ReadLine();
                        competencias.Add(competencia);
                        perfilProfissional.Competencias= competencias;

                        perfilProfissional.Habilidades = habilidades;
                        perfilProfissional.Competencias = competencias;
                        novoUsuario.PerfilProfissionals = perfilProfissional;

                        Console.WriteLine("\nInformações salvas com sucessso!");
                        Console.WriteLine("Formação academica:" + perfilProfissional.FormacaoAcademica);
                        Console.WriteLine("Experiência Profissional: " + perfilProfissional.ExperienciaProfissional);

                        var listaHabilidades= perfilProfissional.listarHabilidade();
                        foreach (Habilidade hab in listaHabilidades){
                            Console.WriteLine($"{hab.nome}");
                            Console.WriteLine($"{hab.descricao}");
                             Console.WriteLine($"{hab.tipo}");
                        }    //repetir para competencia

                         var listaCompetencia= perfilProfissional.listarCompetencias();
                        foreach (Competencia Com in listaCompetencia){
                            Console.WriteLine($"{Com.Nome}");
                            Console.WriteLine($"{Com.Descricao}");
                             Console.WriteLine($"{Com.Aplicabilidade}");
                        }    //repetir para competencia

                         Console.WriteLine("Deseja adicionar outras habilidades e competênias? 1 - (Sim) 0 - (Não)");
                menu = int.Parse(Console.ReadLine()!);
                if(menu == 0) {  //para sair do laço
                    break;
                }
                }
                    }
                }
            }

            if (menu == 2){
                while (menu > 0) {
                //analise de mercado de trabalho
                Console.WriteLine("Bem-vindo ao cadastro de Analise de mercado!");
                AdicionarAnaliseMercadoTrabalho adicionarAnaliseMercadoTrabalho1 = new AdicionarAnaliseMercadoTrabalho();
                Console.WriteLine("Qual é a descrição do mercado de trabalho?");
                adicionarAnaliseMercadoTrabalho1.descricao = Console.ReadLine();
                Console.WriteLine("Empresa em alta:");
                adicionarAnaliseMercadoTrabalho1.empresasEmAlta = Console.ReadLine();
                Console.WriteLine("Adicionar setor em alta:");
                adicionarAnaliseMercadoTrabalho1.SetoresEmAlta = Console.ReadLine();
                
                List<Object> listaDeAnaliseDeMercado = new List<Object>{};
                listaDeAnaliseDeMercado.Add(adicionarAnaliseMercadoTrabalho1);

                Console.WriteLine("\nInformações salvas com sucessso!");
                Console.WriteLine("Descrição:" + adicionarAnaliseMercadoTrabalho1.descricao);
                Console.WriteLine("Empresas em Alta: " + adicionarAnaliseMercadoTrabalho1.empresasEmAlta);
                Console.WriteLine("Setores em alta: " + adicionarAnaliseMercadoTrabalho1.SetoresEmAlta);
                
                Console.WriteLine("Deseja analisar outro mercado de trabalho? 1 - (Sim) 0 - (Não)");
                menu = int.Parse(Console.ReadLine()!);
                if(menu == 0) {  //para sair do laço
                    break;
                }
                }
            }

            if (menu == 3) {
                while (menu > 0) {
                // cadastro de contato de network
                AdicionarContatoNetworking contatoNetworking = new AdicionarContatoNetworking();
                Console.WriteLine("Qual é o nome do seu contato?");
                contatoNetworking.Nome = Console.ReadLine();
                Console.WriteLine("Qual é o email do seu contato?");
                contatoNetworking.Email = Console.ReadLine();
                Console.WriteLine("Qual é a descrição do seu contato?");
                contatoNetworking.Descricao = Console.ReadLine();
                
                List<Object> listaDeContatos = new List<Object>{};
                listaDeContatos.Add(contatoNetworking);  //para adicionar lista de objetos               
                Console.WriteLine("\nInformações salvas com sucessso!");
                Console.WriteLine("Contato networking:" + contatoNetworking.Nome);
                Console.WriteLine("Email networking " + contatoNetworking.Email);
                Console.WriteLine("Descrição networking" + contatoNetworking.Descricao);

                Console.WriteLine("Deseja cadastrar outro contato? 1 - (Sim) 0 - (Não)");
                menu = int.Parse(Console.ReadLine()!);
                if(menu == 0) {  //para sair do laço
                    break;
                }
                }
            }

            if (menu==4){
                while (menu > 0) {
                //atividade de desenvolvimento pessoal

                AtividadeDesenvolvimentoPessoal atividadeDesenvolvimentoPessoal1 = new AtividadeDesenvolvimentoPessoal();
                Console.WriteLine("Qual é o nome?");
                atividadeDesenvolvimentoPessoal1.nome = Console.ReadLine();
                Console.WriteLine("Qual é a descrição?");
                atividadeDesenvolvimentoPessoal1.Descricao = Console.ReadLine();
                Console.WriteLine("Qual é a duração?");
                List<AdicionarContatoNetworking> contatoNetworkings = new List<AdicionarContatoNetworking>();
                 List<AdicionarAnaliseMercadoTrabalho> analiseMercadoTrabalhos = new List<AdicionarAnaliseMercadoTrabalho>();


                List<Object> listaDeAtividadeDesenvolvimentoPessoa = new List<Object>{};
                listaDeAtividadeDesenvolvimentoPessoa.Add(atividadeDesenvolvimentoPessoal1);  //para adicionar lista de objetos
                Console.WriteLine("\nInformações salvas com sucessso!");
                Console.WriteLine("Nome:" + atividadeDesenvolvimentoPessoal1.nome);
                Console.WriteLine("Descrição:" + atividadeDesenvolvimentoPessoal1.Descricao);
                Console.WriteLine("Duração:" + atividadeDesenvolvimentoPessoal1.Duracao);
                Console.WriteLine("Deseja adicionar outra lista de atividade de desenvilvimento pessoal? 1 - (Sim) 0 - (Não)");
                menu = int.Parse(Console.ReadLine()!);
                if(menu == 0) {  //para sair do laço
                    break;
                }
                }
            }

            if (menu==5){
                 while (menu > 0) {
                // metas e objetivos
                MetaObjetivos MetaObjetivos1 = new MetaObjetivos();
                Console.WriteLine("Qual é o nome da meta ou objetivo?");
                MetaObjetivos1.Nome = Console.ReadLine();
                Console.WriteLine("Qual é a descrição da meta ou objetivo?");
                MetaObjetivos1.Descricao = Console.ReadLine();
                Console.WriteLine("Qual é a descrição da meta ou objetivo?");
                MetaObjetivos1.Prazo = Console.ReadLine();

                 List<Object> listaDeMetasObjetivos = new List<Object>{};
                listaDeMetasObjetivos.Add(MetaObjetivos1);  //para adicionar lista de objetos
                Console.WriteLine("\nInformações salvas com sucessso!");
                Console.WriteLine("Nome:" + MetaObjetivos1.Nome);
                Console.WriteLine("Descrição:" + MetaObjetivos1.Descricao);
                Console.WriteLine("Duração:" + MetaObjetivos1.Prazo);
                Console.WriteLine("Deseja cadastrar outra meta ou objetivo? 1 - (Sim) 0 - (Não)");
                menu = int.Parse(Console.ReadLine()!);
                if(menu == 0) {  //para sair do laço
                    break;
                }
                }

            }
        }
    }

}