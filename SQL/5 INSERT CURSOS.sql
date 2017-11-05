/*http://guiadoestudante.abril.com.br/profissoes/ */

SET IDENTITY_INSERT TB_CURSO ON;
GO


INSERT INTO tb_curso(Id_Curso,Tipo_Curso,Nome_Curso,Descricao_Curso) VALUES
--*ADMINISTRA��O, GEST�O E NEG�CIOS
(2,'Gradua��o','Administra��o','O administrador gerencia recursos financeiros, materiais ou humanos de uma empresa. Ele tem lugar em praticamente todos os departamentos de uma organiza��o p�blica, privada ou sem fins lucrativos. Em recursos humanos, responde pelo relacionamento da empresa com funcion�rios e sindicatos, gerencia admiss�es e demiss�es, planos de carreira e benef�cios. No departamento de compras, faz cota��o de pre�os, providencia a aquisi��o de mat�rias-primas e insumos, negocia com fornecedores e controla os estoques. Em vendas, encarrega-se da negocia��o de pre�os, condi��es de pagamento e prazos de entrega com clientes e das atividades de publicidade e marketing. No departamento financeiro, lida com pagamentos e recebimentos, a agenda de impostos ou a cobran�a de clientes. Em ind�strias, trabalha no controle de qualidade e de estoques de produtos acabados. Ele pode, ainda, definir as pol�ticas corporativas, preocupando-se, por exemplo, com a��es de sustentabilidade e responsabilidade social. Seja qual for a �rea de atua��o, esse bacharel precisa se manter atualizado com a economia mundial e nacional, as tend�ncias de consumo e a legisla��o na �rea de atua��o da empresa. Cursos de especializa��o, como MBAs, s�o essenciais para crescer na carreira. Voc� pode ingressar no mercado como tecn�logo.'),
(3,'Gradua��o','Administra��o P�blica','O bacharel em Administra��o P�blica � o administrador especializado no gerenciamento de institui��es governamentais e na elabora��o e acompanhamento de pol�ticas p�blicas. Seu principal campo de trabalho est� em minist�rios, secretarias, concession�rias de servi�os p�blicos e �rg�os federais, estaduais ou municipais, de �reas como sa�de, educa��o, assist�ncia social, habita��o e cultura. Nessas institui��es, ele elabora, coordena e avalia pol�ticas que t�m como objetivo atender a demandas coletivas, como o combate � exclus�o social, ao analfabetismo e � subnutri��o, entre outros temas, atuando inclusive de forma preventiva. Ao elaborar uma pol�tica p�blica, ele estabelece seus objetivos e suas diretrizes, analisa a viabilidade das linhas de financiamento com recursos p�blicos e privados, acompanha licita��es e controla o or�amento. Organizar a infraestrutura, a log�stica e a opera��o em campanhas de vacina��o ou de constru��o de moradias s�o exemplos de atividades da al�ada desse profissional. Apesar de o principal nicho de mercado estar no setor p�blico, o profissional encontra oportunidades em associa��es sem fins lucrativos, como organiza��es n�o governamentais (ONGs), ou em empresas privadas, na articula��o de a��es em parceria com o governo ou na �rea de responsabilidade social. Pode ainda atuar como pol�tico. Voc� pode ingressar na carreira com um curso superior de tecnologia.'),
(4,'Gradua��o','Agroneg�cios e Agropecu�ria',''),
(5,'Gradua��o','Ci�ncias Aeron�uticas',''),
(6,'Gradua��o','Ci�ncias Atuariais',''),
(7,'Gradua��o','Ci�ncias Cont�beis',''),
(8,'Gradua��o','Ci�ncias Econ�micas',''),
(9,'Gradua��o','Com�rcio Exterior',''),
(10,'Gradua��o','Defesa e Gest�o Estrat�gica Internacional',''),
(11,'Gradua��o','Gastronomia',''),
(12,'Gradua��o','Gest�o Comercial',''),
(13,'Gradua��o','Gest�o de Recursos Humanos',''),
(14,'Gradua��o','Gest�o de Seguran�a Privada',''),
(15,'Gradua��o','Gest�o de Turismo',''),
(16,'Gradua��o','Gest�o Financeira',''),
(18,'Gradua��o','Gest�o P�blica',''),
(19,'Gradua��o','Gest�o Empresarial',''),/*n�o tem no site*/
(20,'Gradua��o','Hotelaria',''),
(21,'Gradua��o','Log�stica',''),
(22,'Gradua��o','Marketing',''),
(23,'Gradua��o','Neg�cios Imobili�rios',''),
(24,'Gradua��o','Pilotagem Profissional de Aeronaves',''),
(25,'Gradua��o','Processos Gerenciais',''),
(26,'Gradua��o','Seguran�a P�blica',''),
(27,'Gradua��o','Turismo',''),

/*Artes e Design*/

(28,'Gradua��o','Anima��o',''),
(29,'Gradua��o','Arquitetura e Urbanismo',''),
(30,'Gradua��o','Comunica��o das Artes do Corpo',''),
(31,'Gradua��o','Conserva��o e Restauro',''),
(32,'Gradua��o','Dan�a',''),
(33,'Gradua��o','Design',''),
(34,'Gradua��o','Design de Games',''),
(35,'Gradua��o','Design de Interiores',''),
(36,'Gradua��o','Design de Moda',''),
(37,'Gradua��o','Fotografia',''),
(38,'Gradua��o','Hist�ria da Arte',''),
(39,'Gradua��o','Jogos Digitais',''),
(40,'Gradua��o','Luteria',''),
(41,'Gradua��o','M�sica',''),
(42,'Gradua��o','Produ��o C�nica',''),
(43,'Gradua��o','Produ��o Fonogr�fica',''),
(44,'Gradua��o','Teatro',''),
/*Ci�ncias Biol�gicas e da Terra*/

(45,'Gradua��o','Agroecologia',''),
(46,'Gradua��o','Agronomia',''),
(47,'Gradua��o','Alimentos',''),
(48,'Gradua��o','Biocombust�veis',''),
(49,'Gradua��o','Biotecnologia',''),
(50,'Gradua��o','Biotecnologia e Bioqu�mica',''),
(51,'Gradua��o','Ci�ncia e Tecnologia de Alimentos',''),
(52,'Gradua��o','Ci�ncias Agr�rias',''),
(53,'Gradua��o','Ci�ncias Biol�gicas',''),
(54,'Gradua��o','Ci�ncias Naturais e Exatas',''),
(55,'Gradua��o','Ecologia',''),
(56,'Gradua��o','Geof�sica',''),
(57,'Gradua��o','Geologia',''),
(58,'Gradua��o','Gest�o Ambiental',''),
(59,'Gradua��o','Medicina Veterin�ria',''),
(60,'Gradua��o','Meteorologia',''),
(61,'Gradua��o','Oceanografia',''),
(62,'Gradua��o','Produ��o de Bebidas',''),
(63,'Gradua��o','Produ��o Sucroalcooleira',''),
(64,'Gradua��o','Zootecnia',''),

/*Ci�ncias Exatas e Inform�tica*/

(65,'Gradua��o','An�lise e Desenvolvimento de Sistemas','<p>O profissional de An�lise e Desenvolvimento de Sistemas � respons�vel por desenvolver, analisar, projetar, implementar e atualizar sistemas de informa��o de diferentes �reas. Tamb�m programa computadores e cria softwares que proporcionam a melhor usabilidade das m�quinas, aumentando sua capacidade e velocidade.</p>
            <p>Os primeiros passos do curso de gradua��o em An�lise e Desenvolvimento de Sistemas s�o fundamentados por disciplinas b�sicas, como c�lculo e linguagens de computa��o. Em um segundo momento o aluno passa para a parte pr�tica com a realiza��o de an�lises, programa��o e administra��o de redes de computadores.</p>
            <p>A procura pelos profissionais de An�lise e Desenvolvimento de Sistemas no mercado de trabalho est� sempre em alta, afinal hoje em dia toda organiza��o tem a necessidade de manter seus sistemas informatizados sempre atualizados.</p>
            <div class="text-center"><h2>Mercado de Trabalho</h2></div>
            <p>Outros mercados de relev�ncia para o graduado em An�lise e Desenvolvimento de Sistemas � EAD s�o das empresas de Tecnologia de Informa��o (TI), de telecomunica��es, do trabalho aut�nomo, principalmente atuando como desenvolvedor de aplicativos (um mercado ainda em crescimento) e a nova tend�ncia do trabalho remoto (a dist�ncia) para corpora��es internacionais.</p>
            <p>Al�m da realiza��o do servi�o o profissional de An�lise e Desenvolvimento de Sistemas tamb�m agrega a fun��o de prestar suporte t�cnico tanto para empresas quanto para usu�rios.</p>'),
(66,'Gradua��o','Astronomia',''),
(67,'Gradua��o','Banco de Dados',''),
(68,'Gradua��o','Ci�ncia da Computa��o',''),
(69,'Gradua��o','Ci�ncia e Tecnologia',''),
(70,'Gradua��o','Computa��o',''),
(71,'Gradua��o','Estat�stica',''),
(72,'Gradua��o','F�sica',''),
(73,'Gradua��o','Gest�o da Tecnologia da Informa��o',''),
(74,'Gradua��o','Inform�tica Biom�dica',''),
(75,'Gradua��o','Matem�tica',''),
(76,'Gradua��o','Nanotecnologia',''),
(77,'Gradua��o','Qu�mica',''),
(78,'Gradua��o','Redes de Computadores',''),
(79,'Gradua��o','Seguran�a da Informa��o',''),
(80,'Gradua��o','Sistemas de Informa��o',''),
(81,'Gradua��o','Sistemas para Internet',''),

/*Ci�ncias Sociais e Humanas*/

(82,'Gradua��o','Arqueologia',''),
(83,'Gradua��o','Ci�ncias Humanas',''),
(84,'Gradua��o','Ci�ncias Sociais',''),
(85,'Gradua��o','Comunica��o Assistiva',''),
(86,'Gradua��o','Cooperativismo',''),
(87,'Gradua��o','Direito',''),
(88,'Gradua��o','Economia Dom�stica',''),
(89,'Gradua��o','Escrita Criativa',''),
(90,'Gradua��o','Estudos de G�nero e Diversidade',''),
(91,'Gradua��o','Filosofia',''),
(92,'Gradua��o','Geografia',''),
(93,'Gradua��o','Gest�o de Cooperativas',''),
(94,'Gradua��o','Hist�ria',''),
(95,'Gradua��o','Letras',''),
(96,'Gradua��o','Libras',''),
(97,'Gradua��o','Lingu�stica',''),
(98,'Gradua��o','Museologia',''),
(99,'Gradua��o','Pedagogia',''),
(100,'Gradua��o','Psicopedagogia',''),
(101,'Gradua��o','Rela��es Internacionais',''),
(102,'Gradua��o','Servi�o Social',''),
(103,'Gradua��o','Teologia',''),
(104,'Gradua��o','Tradutor e Int�rprete',''),

/*Comunica��o e Informa��o*/
(105,'Gradua��o','Arquivologia',''),
(106,'Gradua��o','Biblioteconomia',''),
(107,'Gradua��o','Cinema e Audiovisual',''),
(108,'Gradua��o','Comunica��o e Multimeios',''),
(109,'Gradua��o','Comunica��o Institucional',''),
(110,'Gradua��o','Comunica��o Organizacional',''),
(111,'Gradua��o','Educomunica��o',''),
(112,'Gradua��o','Estudos de M�dia',''),
(113,'Gradua��o','Eventos',''),
(114,'Gradua��o','Gest�o da Informa��o',''),
(115,'Gradua��o','Jornalismo',''),
(116,'Gradua��o','Produ��o Audiovisual',''),
(117,'Gradua��o','Produ��o Cultural',''),
(118,'Gradua��o','Produ��o Editorial',''),
(119,'Gradua��o','Produ��o Multim�dia',''),
(120,'Gradua��o','Produ��o Publicit�ria',''),
(121,'Gradua��o','Publicidade e Propaganda',''),
(122,'Gradua��o','R�dio e TV',''),
(123,'Gradua��o','Rela��es P�blicas',''),
(124,'Gradua��o','Secretariado',''),
(125,'Gradua��o','Secretariado Executivo',''),

/*Engenharia e Produ��o*/
(126,'Gradua��o','Agrimensura',''),
(127,'Gradua��o','Aquicultura',''),
(128,'Gradua��o','Automa��o Industrial',''),
(129,'Gradua��o','Constru��o Civil',''),
(130,'Gradua��o','Constru��o Naval',''),
(131,'Gradua��o','Eletr�nica Industrial',''),
(132,'Gradua��o','Eletrot�cnica Industrial',''),
(133,'Gradua��o','Engenharia Ac�stica',''),
(134,'Gradua��o','Engenharia Aeron�utica',''),
(135,'Gradua��o','Engenharia Agr�cola',''),
(136,'Gradua��o','Engenharia Ambiental e Sanit�ria',''),
(137,'Gradua��o','Engenharia Biom�dica',''),
(138,'Gradua��o','Engenharia Cartogr�fica e de Agrimensura',''),
(139,'Gradua��o','Engenharia Civil',''),
(140,'Gradua��o','Engenharia da Computa��o',''),
(141,'Gradua��o','Engenharia de Alimentos',''),
(142,'Gradua��o','Engenharia de Bioprocessos e Biotecnologia',''),
(143,'Gradua��o','Engenharia de Biossistemas',''),
(144,'Gradua��o','Engenharia de Controle e Automa��o',''),
(145,'Gradua��o','Engenharia de Energia',''),
(146,'Gradua��o','Engenharia de Inova��o',''),
(147,'Gradua��o','Engenharia de Materiais',''),
(148,'Gradua��o','Engenharia de Minas',''),
(149,'Gradua��o','Engenharia de Pesca',''),
(150,'Gradua��o','Engenharia de Petr�leo',''),
(151,'Gradua��o','Engenharia de Produ��o',''),
(152,'Gradua��o','Engenharia de Seguran�a no Trabalho',''),
(153,'Gradua��o','Engenharia de Sistemas',''),
(154,'Gradua��o','Engenharia de Software',''),
(155,'Gradua��o','Engenharia de Telecomunica��es',''),
(156,'Gradua��o','Engenharia de Transporte e da Mobilidade',''),
(157,'Gradua��o','Engenharia El�trica',''),
(158,'Gradua��o','Engenharia Eletr�nica',''),
(159,'Gradua��o','Engenharia F�sica',''),
(160,'Gradua��o','Engenharia Florestal',''),
(161,'Gradua��o','Engenharia H�drica',''),
(162,'Gradua��o','Engenharia Industrial Madeireira',''),
(163,'Gradua��o','Engenharia Mec�nica',''),
(164,'Gradua��o','Engenharia Mecatr�nica',''),
(165,'Gradua��o','Engenharia Metal�rgica',''),
(166,'Gradua��o','Engenharia Naval',''),
(167,'Gradua��o','Engenharia Nuclear',''),
(168,'Gradua��o','Engenharia Qu�mica',''),
(169,'Gradua��o','Engenharia T�xtil',''),
(170,'Gradua��o','Fabrica��o Mec�nica',''),
(171,'Gradua��o','Geoprocessamento',''),
(172,'Gradua��o','Gest�o da Produ��o Industrial',''),
(173,'Gradua��o','Gest�o da Qualidade',''),
(174,'Gradua��o','Irriga��o e Drenagem',''),
(175,'Gradua��o','Manuten��o de Aeronaves',''),
(176,'Gradua��o','Manuten��o Industrial',''),
(177,'Gradua��o','Materiais',''),
(178,'Gradua��o','Mecatr�nica Industrial',''),
(179,'Gradua��o','Minera��o',''),
(180,'Gradua��o','Papel e Celulose',''),
(181,'Gradua��o','Petr�leo e G�s',''),
(182,'Gradua��o','Processos Metal�rgicos',''),
(183,'Gradua��o','Processos Qu�micos',''),
(184,'Gradua��o','Produ��o T�xtil',''),
(185,'Gradua��o','Saneamento Ambiental',''),
(186,'Gradua��o','Seguran�a no Trabalho',''),
(187,'Gradua��o','Silvicultura',''),
(188,'Gradua��o','Sistemas Biom�dicos',''),
(189,'Gradua��o','Sistemas de Telecomunica��es',''),
(190,'Gradua��o','Sistemas El�tricos',''),
(191,'Gradua��o','Sistemas Embarcados',''),
(192,'Gradua��o','Transporte',''),
/*Sa�de e Bem-Estar*/
(193,'Gradua��o','Biomedicina',''),
(194,'Gradua��o','Educa��o F�sica',''),
(195,'Gradua��o','Enfermagem',''),
(196,'Gradua��o','Esporte',''),
(197,'Gradua��o','Est�tica e Cosm�tica',''),
(198,'Gradua��o','Farm�cia',''),
(199,'Gradua��o','Fisioterapia',''),
(200,'Gradua��o','Fonoaudiologia',''),
(201,'Gradua��o','Gerontologia',''),
(202,'Gradua��o','Gest�o Desportiva e de Lazer',''),
(203,'Gradua��o','Gest�o em Sa�de',''),
(204,'Gradua��o','Gest�o Hospitalar',''),
(205,'Gradua��o','Medicina',''),
(206,'Gradua��o','Musicoterapia',''),
(207,'Gradua��o','Naturologia',''),
(208,'Gradua��o','Nutri��o',''),
(209,'Gradua��o','Obstetr�cia',''),
(210,'Gradua��o','Odontologia',''),
(211,'Gradua��o','Oft�lmica',''),
(212,'Gradua��o','�ptica e Optometria',''),
(213,'Gradua��o','Psicologia',''),
(214,'Gradua��o','Quiropraxia',''),
(215,'Gradua��o','Radiologia',''),
(216,'Gradua��o','Sa�de Coletiva',''),
(217,'Gradua��o','Terapia Ocupacional',''),

/*Engenharia e Produ��o*/
(218,'Gradua��o','Mec�nica - Processos de Soldagem ',''),
(219,'Gradua��o','Refrigera��o, Ventila��o e Ar Condicionado',''),
(220,'Gradua��o','Mec�nica - Processos de Produ��o ',''),
(221,'Gradua��o','Mec�nica - Projetos ',''),
(222,'Gradua��o','Mec�nica de Precis�o',''),
(223,'Gradua��o','Hidr�ulica e Saneamento Ambiental ',''),
(224,'Gradua��o','Soldagem',''),

--*ADMINISTRA��O, GEST�O E NEG�CIOS
(225,'Gradua��o','Gest�o de Neg�cios e Inova��o ',''),

/*Engenharia e Produ��o*/
(226,'Gradua��o','Constru��o de Edif�cios',''),
(227,'Gradua��o','Transporte Terrestre',''),
(228,'Gradua��o','Pol�meros',''),

/*Ci�ncias Sociais e Humanas*/
(229,'P�s-gradua��o','Educa��o em Direitos Humanos',''),
(230,'P�s-gradua��o','Especializa��o em Pol�ticas de Promo��o da Igualdade Racial na Escola',''),

/*Ci�ncias Exatas e Inform�tica*/
(231,'P�s-gradua��o','Especializa��o em Ci�ncia e Tecnologia',''),
(232,'P�s-gradua��o','Especializa��o em Novas Tecnologias no Ensino de Matem�tica',''),

--*ADMINISTRA��O, GEST�O E NEG�CIOS
(233,'P�s-gradua��o','Especializa��o em Planejamento Implementa��o e Gest�o da Educa��o � Dist�ncia',''),

/*Exatas e Biol�gicas*/
(234,'Gradua��o','Licenciatura em Ci�ncias Naturais e Matem�tica',''),

/*Ci�ncias Exatas e Inform�tica*/
(235,'P�s-gradua��o','Especializa��o em Tecnologias Digitais de Informa��o e Comunica��o para Ensino B�sico',''),

/*Comunica��o e Informa��o*/
(236,'P�s-gradua��o','Especializa��o em M�dias na Educa��o',''),

--*ADMINISTRA��O, GEST�O E NEG�CIOS
(237,'P�s-gradua��o','Especializa��o em Gest�o P�blica ',''),
/*Sa�de e Bem-Estar*/
(238,'P�s-gradua��o','Especializa��o em Enfermagem e Cuidado Pr� Natal',''),
/*Ci�ncias Sociais e Humanas*/
(239,'Gradua��o','Licenciatura em Pedagogia',''),

/*Engenharia e Produ��o*/
(240,'Gradua��o','Microeletr�nica',''),
(241,'Gradua��o','Instala��es Eletricas',''),
(242,'Gradua��o','Controle de Obras',''),
/*Comunica��o e Informa��o*/
(243,'Gradua��o','Automa��o de Escrit�rios e Secretariado ','');

GO

SET IDENTITY_INSERT TB_CURSO OFF;

GO