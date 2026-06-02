using ProjetoWeb01.Dados;
using ProjetoWeb01.Classes.Entidades;


namespace ProjetoWeb01.Classes.Serv
{
    //validar os dados passados pelo usuario,condições negativas erros ou etc
    public class AlunoService
    {
        //campo

        private readonly AlunoContext dbContext;

        //Construtor
        public AlunoService(AlunoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Tarefa
        public async Task<ResultadoCadastro> CadastrarAluno(Aluno aluno)
        {
            try
            {
                //validação basica 
                if (string.IsNullOrWhiteSpace(aluno.Nome))
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor , insira o nome valido de aluno"
                    };
                }

                if(aluno.RA <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor,informe um RA válido"
                    };
                }
                if (aluno.CursoID <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor , Selecione um curso"

                    };
                }
                //Definir os status padrão para novos cadastros !
                aluno.StatusWIFI = "inativo";
                aluno.StatusAction = "Aguardando aprovação";

                //Adicionar o aluno ao banco de dados
                dbContext.Alunos.Add(aluno);
                await dbContext.SaveChangesAsync();//comando de espera para salvar o conteudo no db

                return new ResultadoCadastro
                {
                    Sucesso = true,
                    Mensagem = "Aluno cadastrado com sucesso"
                };
            }

            catch(Exception ex)
            {
                return new ResultadoCadastro
                {
                    Sucesso = false,
                    Mensagem=$"Erro ao cadastrar o aluno :{ex.Message}"
                };
            }
        }
    }
}
