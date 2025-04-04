# ProjetoTrabalho
 Sistema de Gerenciamento de Oficina de Reparos
Sistema em C# para controle de ordens de serviço, estoque de peças e cadastro de clientes, funcionários e fornecedores em uma oficina de reparos de eletrônicos.

🛠️ Funcionalidades
✔ Cadastro de Clientes (nome, CPF, e-mail)
✔ Registro de Ordens de Serviço (aparelhos, defeitos, valores)
✔ Controle de Estoque (peças e aparelhos em reparo)
✔ Gestão de Funcionários (matrícula e atendimento)
✔ Fornecedores (razão social e CNPJ)
✔ Status de Serviço (Pendente, Em Andamento, Concluído, Retirado)

🖥️ Tecnologias
Linguagem: C# (.NET)

Estrutura: POO (Classes, Herança, Enums)

Recursos:

DateTime para registro de entradas

List<T> para gerenciamento de estoque

Enum para tipos de produtos e status

⚙️ Como Executar
Pré-requisitos:

.NET SDK instalado (Download aqui)

Compilar e executar:

bash
Copy
dotnet build
dotnet run
Fluxo no terminal:

Escolha entre criar uma Ordem de Serviço ou Adicionar Peça ao Estoque.

Siga as instruções interativas para preenchimento dos dados.

📂 Estrutura do Código
plaintext
Copy
ProjetoTrabalho/  
├── Entities/  
│   ├── Cliente.cs          # Dados do cliente e status  
│   ├── Funcionario.cs      # Cadastro de atendentes  
│   ├── Produto.cs          # Aparelhos (TV, Monitor, Controle)  
│   ├── Fornecedor.cs       # Informações de fornecedores  
│   ├── Estoque.cs          # Listas de peças e produtos  
│   ├── OrdemDeServico.cs   # Gestão de ordens  
├── Enums/  
│   ├── TipoProduto.cs      # Tipos de aparelhos  
│   ├── Status.cs           # Status do serviço  
│   ├── TipoUsuario.cs      # Classificação de usuários  
└── Program.cs              # Lógica principal e menus  
🎯 Exemplo de Uso
Criar Ordem de Serviço:

Insira dados do cliente, aparelho (TV/Monitor/Controle) e defeito.

Atribua um funcionário e valor do reparo.

Gerenciar Estoque:

Adicione ou remova peças (ex: "Tela 32", "Cabo de Força").

Alterar Status:

Atualize o status do serviço para Concluído ou Retirado.

📝 Licença
MIT License.

✉️ Contato
Se tiver dúvidas ou sugestões, entre em contato!

🔍 Observações
O sistema não persiste dados em banco (é volátil, reiniciando a cada execução).

Para versões futuras: integrar com SQLite ou JSON para armazenamento.
