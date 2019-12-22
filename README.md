# Front-Controller
Síntese sobre o padrão de desenho *Front Controller* para a cadeira de Desenho Implementação de *Software* da Universidade da Madeira.

Feito por:
* Gonçalo Passos 2030415
* Henrique Sousa 20xxxxx
* João Alves 20xxxxx
* Diogo Matthew 20xxxxx

## Contexto

O padrão de desenho *Front Controller* é um padrão que fornece um mecanismo centralizado para tratar pedidos, redirecionando o pedido para uma entidade final, que é responsável pelo mesmo.

O padrão Front Controller é constituído pelas seguintes entidades:
* ***Controller*** – É o ponto de contacto inicial para lidar com todas os pedidos do sistema. Pode ter auxílio de outras entidades para os processos de autenticação, ou outro tipo de processamento, antes do pedido chegar ao processo responsável por esse pedido.
* ***Dispatcher*** – Entidade responsável por redirecionar os pedidos para a entidade final  responsável por tratar o pedido.
* ***View*** – Uma *view* representa e exibe informações solicitadas para o cliente. É a entidade aos quais os pedidos se referem.

Pode ser implementado em aplicações *web* ou *desktop*, sendo independente de linguagens de programação. Atualmente, é muito utilizado em *frameworks* de desenvolvimento *web*, na implementação de mecanismos de rotas.

![UML do Front Controller](https://i.imgur.com/8qfKHyV.gif)
