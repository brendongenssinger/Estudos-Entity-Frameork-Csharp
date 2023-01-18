# Estudos-Entity-Frameork-Csharp
Estudos referente ao framework bastante utilizado nas Empresas. 


***

Objetivo do estudo é apenas mostrar como é utilizado o Entity Framework. 
Mas o que é o Entity Frameork ? 
É um mapeador realcional de objeto (ORM) que :
- Permite que desenvolvedores .Net trabalhem com um banco de dados usando objetos .Net .
Como assim ?
Ele elimina aquela necessidade de você ter que escrever Query's SQL e apenas utiliza objetos do código e faz isso pra você.

Mas ele é uma faca de dois gumes, ao mesmo tempo que ele te ajuda, pode te dar uma dor de cabeça.
Recomendo atenção quando for utilizar ele e saber separar as responsabilidades do objetos.
Um exemplo de problemas que ocorrem e que já presenciei, foram os relacionamentos mal feitos e não havia abstração do código e nem padronização de Repositórios de acesso ao DataAcess ( Acesso ao Banco de Dados ). 

Ele fornece uma opção também que acho que legal, é a Migration, caso você mude a sua model que tem relacionamento com o Entity Frameork, ele fará a atualização do banco de dados.
