<h2>Sistema para gerenciamento de operações de câmbio desenvolvido com  C#(WindowsForms) e Banco de dados (SqlServer)</h2>

<h3>O sistema conta com as seguintes funcionalidades</h3>

- Cadastro de valores para conversão com uma lista previamente cadastrada de moedas;
- Atualização de moedas (Simbolo e Valor de conversão);
- Cadastro para operação de câmbio;
- Calculadora que faz a conversão das moedas;
- Visualização de todas as operações com filtros por nome de cliente e intervalo de data;
- Visualização dos valores totais de todas as operações e taxas já cadastradas com filtro para intervalo de data;
- Visualização detalhada de cada operação cadastrada.   

<h2>:card_index_dividers: Como compilar o projeto:</h2>

1.  Após abrir o Visual Studio 2019 clique no botão <b>Clone a repository</b>, cole o link deste repositório e escolha o local de destino e clique no botão <b>clone</b>

2.  Usando o Microsoft SQL Server Management Studio 18 cole o [script do banco de dados](https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/Banco_SQL.sql) e execute para criar o banco e as tabelas

3.  Para se conectar ao banco SqlServer vá em Tools > Connect to Database > em Data source, mude para <b>Microsoft SQL Server</b> > em Server name coloque um ponto(.) > abaixo em Connect to a database escolha o banco <b>GerenciadorDeOperacoes</b> e clique em <b>Ok</b>
 
4.  No Server Explorer > com o botão direito, clique na conexão > <b>propriedades</b> > copie a connection string e cole no lugar da que está setada na classe Conexao dentro do projeto Model obs:*[ConnectionString](https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/images/ConnectionString.png)*

5. O projeto está pronto para ser compilado

<h2>:page_with_curl: Como o sistema funciona:</h2> 

- Para cadastrar uma moeda clique no botão **Moedas**

<img src="https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/images/Inicio.gif" width="600">

- Após ser redirecionado, Informe a moeda, símbolo e o valor de conversão da moeda e clique no botão **Cadastrar Moeda**
- *Para atualizar o valor ou o símbolo de uma moeda já cadastrada clique na célula da moeda que deseja alterar algum valor, após a alteração clique no botão **Atualizar Moeda***

<img src="https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/images/CadastroDeMoeda.gif" width="600">

- Para cadastrar uma operação, vá para a tela inicial e clique no botão **Operações**, após ser redirecionado, informe as informações da operação e clique em **Cadastrar Operação**

<img src="https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/images/CadastroDeOperacao.gif" width="700">

- Após cadastrar uma operação, volte para a tela inicial e clique no botão **Relatórios** para visualizar e filtrar todas as Operaçoes de Câmbio

<img src="https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/images/PesquisaDeOperacao.gif" width="710"> 

- Clique na célula da operação desejada e clique no botão **Visualizar** para ver os detalhes da operação

<img src="https://github.com/Meiteusz/Gerenciador-de-Operacoes/blob/main/images/DetalhesOperacao.png" align="top" width="250">

- Clique no botão Ok para voltar a tela de visualização de todas as operações

<h2>:gear: Ferramentas utilizadas</h2>

- Ambiente de desenvolvimento: Visual Studio 2019
- SGBD: Microsoft SQL Server Management Studio 18

*Sistema desenvolvido por Matheus Wietcovski Teixeira para o desafio de programação da jornada havan labs com execução pela ProWay*
