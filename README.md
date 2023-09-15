# AmazonDoMilhao

Projeto simples e rápido que fiz para um amigo que faz vendas na Amazon.
Ele precisava de um conversor de arquivos, pegar o arquivo gerado pela Amazon e converter no formato que o fornecedor Chinês dele aceita.

﻿Projeto 'Amazon do Milhão'

Descrição:
Software que recebe um arquivo .txt da Amazon, no formato tsv (Tab Separated Values) 
com quebra de linha no final (\n).

O objetivo final é gerar um arquivo .csv no formato csv (Comma Separated Values) 
com apenas algumas colunas especificadas pelo cliente.


Funções:
* Escolher arquivo de entrada (.txt em formato tsv). 
* Escolher nome/local do arquivo de sáida (.csv em formato csv)
* Gerar arquivo de saída 
* Cadastrar associações de SKU -> URL
	- Arquivo .bin com valores SKU e URL separado por ';' (ponto e vírgula) 


* Converter arquivos:

Arquivo original Amazon (.txt):
					
1. //(Order Nº) vai preencher manualmente	
2. quantity-purchased			
3. product-name				
4. //(color deixa em branco)	
5. recipient-name				
6. ship-address-1				
7. ship-address-2				
8. delivery-Instructions		
9. cpf							
10. ship-city					
11. ship-postal-code			
12. ship-state					
13. ship-country				
14. ship-phone-number			
15. ship-phone-number			
16. sku (converted to url)		


Arquivo final Chines (.csv):		

1.  Order No				 
2.  Lineitem quantity		 
3.  Lineitem name			 
4.  Lineitem color			 
5.  Shipping Name			 
6.  Shipping Street			 
7.  Shipping Address1		 
8.  Shipping Address2		 
9.  Shipping Company/CPF	 
10. Shipping City			 
11. Shipping Zip			 
12. Shipping Province		 
13. Shipping Country		 
14. Shipping Phone			 
15. Phone					 
16. Product link
