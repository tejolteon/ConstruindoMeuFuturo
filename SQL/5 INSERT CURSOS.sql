/*http://guiadoestudante.abril.com.br/profissoes/ */

SET IDENTITY_INSERT TB_CURSO ON;
GO


INSERT INTO tb_curso(Id_Curso,Tipo_Curso,Nome_Curso,Descricao_Curso) VALUES
--*ADMINISTRAÇÃO, GESTÃO E NEGÓCIOS
(2,'Graduação','Administração','O administrador gerencia recursos financeiros, materiais ou humanos de uma empresa. Ele tem lugar em praticamente todos os departamentos de uma organização pública, privada ou sem fins lucrativos. Em recursos humanos, responde pelo relacionamento da empresa com funcionários e sindicatos, gerencia admissões e demissões, planos de carreira e benefícios. No departamento de compras, faz cotação de preços, providencia a aquisição de matérias-primas e insumos, negocia com fornecedores e controla os estoques. Em vendas, encarrega-se da negociação de preços, condições de pagamento e prazos de entrega com clientes e das atividades de publicidade e marketing. No departamento financeiro, lida com pagamentos e recebimentos, a agenda de impostos ou a cobrança de clientes. Em indústrias, trabalha no controle de qualidade e de estoques de produtos acabados. Ele pode, ainda, definir as políticas corporativas, preocupando-se, por exemplo, com ações de sustentabilidade e responsabilidade social. Seja qual for a área de atuação, esse bacharel precisa se manter atualizado com a economia mundial e nacional, as tendências de consumo e a legislação na área de atuação da empresa. Cursos de especialização, como MBAs, são essenciais para crescer na carreira. Você pode ingressar no mercado como tecnólogo.'),
(3,'Graduação','Administração Pública','O bacharel em Administração Pública é o administrador especializado no gerenciamento de instituições governamentais e na elaboração e acompanhamento de políticas públicas. Seu principal campo de trabalho está em ministérios, secretarias, concessionárias de serviços públicos e órgãos federais, estaduais ou municipais, de áreas como saúde, educação, assistência social, habitação e cultura. Nessas instituições, ele elabora, coordena e avalia políticas que têm como objetivo atender a demandas coletivas, como o combate à exclusão social, ao analfabetismo e à subnutrição, entre outros temas, atuando inclusive de forma preventiva. Ao elaborar uma política pública, ele estabelece seus objetivos e suas diretrizes, analisa a viabilidade das linhas de financiamento com recursos públicos e privados, acompanha licitações e controla o orçamento. Organizar a infraestrutura, a logística e a operação em campanhas de vacinação ou de construção de moradias são exemplos de atividades da alçada desse profissional. Apesar de o principal nicho de mercado estar no setor público, o profissional encontra oportunidades em associações sem fins lucrativos, como organizações não governamentais (ONGs), ou em empresas privadas, na articulação de ações em parceria com o governo ou na área de responsabilidade social. Pode ainda atuar como político. Você pode ingressar na carreira com um curso superior de tecnologia.'),
(4,'Graduação','Agronegócios e Agropecuária',''),
(5,'Graduação','Ciências Aeronáuticas',''),
(6,'Graduação','Ciências Atuariais',''),
(7,'Graduação','Ciências Contábeis',''),
(8,'Graduação','Ciências Econômicas',''),
(9,'Graduação','Comércio Exterior',''),
(10,'Graduação','Defesa e Gestão Estratégica Internacional',''),
(11,'Graduação','Gastronomia',''),
(12,'Graduação','Gestão Comercial',''),
(13,'Graduação','Gestão de Recursos Humanos',''),
(14,'Graduação','Gestão de Segurança Privada',''),
(15,'Graduação','Gestão de Turismo',''),
(16,'Graduação','Gestão Financeira',''),
(18,'Graduação','Gestão Pública',''),
(19,'Graduação','Gestão Empresarial',''),/*não tem no site*/
(20,'Graduação','Hotelaria',''),
(21,'Graduação','Logística',''),
(22,'Graduação','Marketing',''),
(23,'Graduação','Negócios Imobiliários',''),
(24,'Graduação','Pilotagem Profissional de Aeronaves',''),
(25,'Graduação','Processos Gerenciais',''),
(26,'Graduação','Segurança Pública',''),
(27,'Graduação','Turismo',''),

/*Artes e Design*/

(28,'Graduação','Animação',''),
(29,'Graduação','Arquitetura e Urbanismo',''),
(30,'Graduação','Comunicação das Artes do Corpo',''),
(31,'Graduação','Conservação e Restauro',''),
(32,'Graduação','Dança',''),
(33,'Graduação','Design',''),
(34,'Graduação','Design de Games',''),
(35,'Graduação','Design de Interiores',''),
(36,'Graduação','Design de Moda',''),
(37,'Graduação','Fotografia',''),
(38,'Graduação','História da Arte',''),
(39,'Graduação','Jogos Digitais',''),
(40,'Graduação','Luteria',''),
(41,'Graduação','Música',''),
(42,'Graduação','Produção Cênica',''),
(43,'Graduação','Produção Fonográfica',''),
(44,'Graduação','Teatro',''),
/*Ciências Biológicas e da Terra*/

(45,'Graduação','Agroecologia',''),
(46,'Graduação','Agronomia',''),
(47,'Graduação','Alimentos',''),
(48,'Graduação','Biocombustíveis',''),
(49,'Graduação','Biotecnologia',''),
(50,'Graduação','Biotecnologia e Bioquímica',''),
(51,'Graduação','Ciência e Tecnologia de Alimentos',''),
(52,'Graduação','Ciências Agrárias',''),
(53,'Graduação','Ciências Biológicas',''),
(54,'Graduação','Ciências Naturais e Exatas',''),
(55,'Graduação','Ecologia',''),
(56,'Graduação','Geofísica',''),
(57,'Graduação','Geologia',''),
(58,'Graduação','Gestão Ambiental',''),
(59,'Graduação','Medicina Veterinária',''),
(60,'Graduação','Meteorologia',''),
(61,'Graduação','Oceanografia',''),
(62,'Graduação','Produção de Bebidas',''),
(63,'Graduação','Produção Sucroalcooleira',''),
(64,'Graduação','Zootecnia',''),

/*Ciências Exatas e Informática*/

(65,'Graduação','Análise e Desenvolvimento de Sistemas','<p>O profissional de Análise e Desenvolvimento de Sistemas é responsável por desenvolver, analisar, projetar, implementar e atualizar sistemas de informação de diferentes áreas. Também programa computadores e cria softwares que proporcionam a melhor usabilidade das máquinas, aumentando sua capacidade e velocidade.</p>
            <p>Os primeiros passos do curso de graduação em Análise e Desenvolvimento de Sistemas são fundamentados por disciplinas básicas, como cálculo e linguagens de computação. Em um segundo momento o aluno passa para a parte prática com a realização de análises, programação e administração de redes de computadores.</p>
            <p>A procura pelos profissionais de Análise e Desenvolvimento de Sistemas no mercado de trabalho está sempre em alta, afinal hoje em dia toda organização tem a necessidade de manter seus sistemas informatizados sempre atualizados.</p>
            <div class="text-center"><h2>Mercado de Trabalho</h2></div>
            <p>Outros mercados de relevância para o graduado em Análise e Desenvolvimento de Sistemas – EAD são das empresas de Tecnologia de Informação (TI), de telecomunicações, do trabalho autônomo, principalmente atuando como desenvolvedor de aplicativos (um mercado ainda em crescimento) e a nova tendência do trabalho remoto (a distância) para corporações internacionais.</p>
            <p>Além da realização do serviço o profissional de Análise e Desenvolvimento de Sistemas também agrega a função de prestar suporte técnico tanto para empresas quanto para usuários.</p>'),
(66,'Graduação','Astronomia',''),
(67,'Graduação','Banco de Dados',''),
(68,'Graduação','Ciência da Computação',''),
(69,'Graduação','Ciência e Tecnologia',''),
(70,'Graduação','Computação',''),
(71,'Graduação','Estatística',''),
(72,'Graduação','Física',''),
(73,'Graduação','Gestão da Tecnologia da Informação',''),
(74,'Graduação','Informática Biomédica',''),
(75,'Graduação','Matemática',''),
(76,'Graduação','Nanotecnologia',''),
(77,'Graduação','Química',''),
(78,'Graduação','Redes de Computadores',''),
(79,'Graduação','Segurança da Informação',''),
(80,'Graduação','Sistemas de Informação',''),
(81,'Graduação','Sistemas para Internet',''),

/*Ciências Sociais e Humanas*/

(82,'Graduação','Arqueologia',''),
(83,'Graduação','Ciências Humanas',''),
(84,'Graduação','Ciências Sociais',''),
(85,'Graduação','Comunicação Assistiva',''),
(86,'Graduação','Cooperativismo',''),
(87,'Graduação','Direito',''),
(88,'Graduação','Economia Doméstica',''),
(89,'Graduação','Escrita Criativa',''),
(90,'Graduação','Estudos de Gênero e Diversidade',''),
(91,'Graduação','Filosofia',''),
(92,'Graduação','Geografia',''),
(93,'Graduação','Gestão de Cooperativas',''),
(94,'Graduação','História',''),
(95,'Graduação','Letras',''),
(96,'Graduação','Libras',''),
(97,'Graduação','Linguística',''),
(98,'Graduação','Museologia',''),
(99,'Graduação','Pedagogia',''),
(100,'Graduação','Psicopedagogia',''),
(101,'Graduação','Relações Internacionais',''),
(102,'Graduação','Serviço Social',''),
(103,'Graduação','Teologia',''),
(104,'Graduação','Tradutor e Intérprete',''),

/*Comunicação e Informação*/
(105,'Graduação','Arquivologia',''),
(106,'Graduação','Biblioteconomia',''),
(107,'Graduação','Cinema e Audiovisual',''),
(108,'Graduação','Comunicação e Multimeios',''),
(109,'Graduação','Comunicação Institucional',''),
(110,'Graduação','Comunicação Organizacional',''),
(111,'Graduação','Educomunicação',''),
(112,'Graduação','Estudos de Mídia',''),
(113,'Graduação','Eventos',''),
(114,'Graduação','Gestão da Informação',''),
(115,'Graduação','Jornalismo',''),
(116,'Graduação','Produção Audiovisual',''),
(117,'Graduação','Produção Cultural',''),
(118,'Graduação','Produção Editorial',''),
(119,'Graduação','Produção Multimídia',''),
(120,'Graduação','Produção Publicitária',''),
(121,'Graduação','Publicidade e Propaganda',''),
(122,'Graduação','Rádio e TV',''),
(123,'Graduação','Relações Públicas',''),
(124,'Graduação','Secretariado',''),
(125,'Graduação','Secretariado Executivo',''),

/*Engenharia e Produção*/
(126,'Graduação','Agrimensura',''),
(127,'Graduação','Aquicultura',''),
(128,'Graduação','Automação Industrial',''),
(129,'Graduação','Construção Civil',''),
(130,'Graduação','Construção Naval',''),
(131,'Graduação','Eletrônica Industrial',''),
(132,'Graduação','Eletrotécnica Industrial',''),
(133,'Graduação','Engenharia Acústica',''),
(134,'Graduação','Engenharia Aeronáutica',''),
(135,'Graduação','Engenharia Agrícola',''),
(136,'Graduação','Engenharia Ambiental e Sanitária',''),
(137,'Graduação','Engenharia Biomédica',''),
(138,'Graduação','Engenharia Cartográfica e de Agrimensura',''),
(139,'Graduação','Engenharia Civil',''),
(140,'Graduação','Engenharia da Computação',''),
(141,'Graduação','Engenharia de Alimentos',''),
(142,'Graduação','Engenharia de Bioprocessos e Biotecnologia',''),
(143,'Graduação','Engenharia de Biossistemas',''),
(144,'Graduação','Engenharia de Controle e Automação',''),
(145,'Graduação','Engenharia de Energia',''),
(146,'Graduação','Engenharia de Inovação',''),
(147,'Graduação','Engenharia de Materiais',''),
(148,'Graduação','Engenharia de Minas',''),
(149,'Graduação','Engenharia de Pesca',''),
(150,'Graduação','Engenharia de Petróleo',''),
(151,'Graduação','Engenharia de Produção',''),
(152,'Graduação','Engenharia de Segurança no Trabalho',''),
(153,'Graduação','Engenharia de Sistemas',''),
(154,'Graduação','Engenharia de Software',''),
(155,'Graduação','Engenharia de Telecomunicações',''),
(156,'Graduação','Engenharia de Transporte e da Mobilidade',''),
(157,'Graduação','Engenharia Elétrica',''),
(158,'Graduação','Engenharia Eletrônica',''),
(159,'Graduação','Engenharia Física',''),
(160,'Graduação','Engenharia Florestal',''),
(161,'Graduação','Engenharia Hídrica',''),
(162,'Graduação','Engenharia Industrial Madeireira',''),
(163,'Graduação','Engenharia Mecânica',''),
(164,'Graduação','Engenharia Mecatrônica',''),
(165,'Graduação','Engenharia Metalúrgica',''),
(166,'Graduação','Engenharia Naval',''),
(167,'Graduação','Engenharia Nuclear',''),
(168,'Graduação','Engenharia Química',''),
(169,'Graduação','Engenharia Têxtil',''),
(170,'Graduação','Fabricação Mecânica',''),
(171,'Graduação','Geoprocessamento',''),
(172,'Graduação','Gestão da Produção Industrial',''),
(173,'Graduação','Gestão da Qualidade',''),
(174,'Graduação','Irrigação e Drenagem',''),
(175,'Graduação','Manutenção de Aeronaves',''),
(176,'Graduação','Manutenção Industrial',''),
(177,'Graduação','Materiais',''),
(178,'Graduação','Mecatrônica Industrial',''),
(179,'Graduação','Mineração',''),
(180,'Graduação','Papel e Celulose',''),
(181,'Graduação','Petróleo e Gás',''),
(182,'Graduação','Processos Metalúrgicos',''),
(183,'Graduação','Processos Químicos',''),
(184,'Graduação','Produção Têxtil',''),
(185,'Graduação','Saneamento Ambiental',''),
(186,'Graduação','Segurança no Trabalho',''),
(187,'Graduação','Silvicultura',''),
(188,'Graduação','Sistemas Biomédicos',''),
(189,'Graduação','Sistemas de Telecomunicações',''),
(190,'Graduação','Sistemas Elétricos',''),
(191,'Graduação','Sistemas Embarcados',''),
(192,'Graduação','Transporte',''),
/*Saúde e Bem-Estar*/
(193,'Graduação','Biomedicina',''),
(194,'Graduação','Educação Física',''),
(195,'Graduação','Enfermagem',''),
(196,'Graduação','Esporte',''),
(197,'Graduação','Estética e Cosmética',''),
(198,'Graduação','Farmácia',''),
(199,'Graduação','Fisioterapia',''),
(200,'Graduação','Fonoaudiologia',''),
(201,'Graduação','Gerontologia',''),
(202,'Graduação','Gestão Desportiva e de Lazer',''),
(203,'Graduação','Gestão em Saúde',''),
(204,'Graduação','Gestão Hospitalar',''),
(205,'Graduação','Medicina',''),
(206,'Graduação','Musicoterapia',''),
(207,'Graduação','Naturologia',''),
(208,'Graduação','Nutrição',''),
(209,'Graduação','Obstetrícia',''),
(210,'Graduação','Odontologia',''),
(211,'Graduação','Oftálmica',''),
(212,'Graduação','Óptica e Optometria',''),
(213,'Graduação','Psicologia',''),
(214,'Graduação','Quiropraxia',''),
(215,'Graduação','Radiologia',''),
(216,'Graduação','Saúde Coletiva',''),
(217,'Graduação','Terapia Ocupacional',''),

/*Engenharia e Produção*/
(218,'Graduação','Mecânica - Processos de Soldagem ',''),
(219,'Graduação','Refrigeração, Ventilação e Ar Condicionado',''),
(220,'Graduação','Mecânica - Processos de Produção ',''),
(221,'Graduação','Mecânica - Projetos ',''),
(222,'Graduação','Mecânica de Precisão',''),
(223,'Graduação','Hidráulica e Saneamento Ambiental ',''),
(224,'Graduação','Soldagem',''),

--*ADMINISTRAÇÃO, GESTÃO E NEGÓCIOS
(225,'Graduação','Gestão de Negócios e Inovação ',''),

/*Engenharia e Produção*/
(226,'Graduação','Construção de Edifícios',''),
(227,'Graduação','Transporte Terrestre',''),
(228,'Graduação','Polímeros',''),

/*Ciências Sociais e Humanas*/
(229,'Pós-graduação','Educação em Direitos Humanos',''),
(230,'Pós-graduação','Especialização em Políticas de Promoção da Igualdade Racial na Escola',''),

/*Ciências Exatas e Informática*/
(231,'Pós-graduação','Especialização em Ciência e Tecnologia',''),
(232,'Pós-graduação','Especialização em Novas Tecnologias no Ensino de Matemática',''),

--*ADMINISTRAÇÃO, GESTÃO E NEGÓCIOS
(233,'Pós-graduação','Especialização em Planejamento Implementação e Gestão da Educação à Distância',''),

/*Exatas e Biológicas*/
(234,'Graduação','Licenciatura em Ciências Naturais e Matemática',''),

/*Ciências Exatas e Informática*/
(235,'Pós-graduação','Especialização em Tecnologias Digitais de Informação e Comunicação para Ensino Básico',''),

/*Comunicação e Informação*/
(236,'Pós-graduação','Especialização em Mídias na Educação',''),

--*ADMINISTRAÇÃO, GESTÃO E NEGÓCIOS
(237,'Pós-graduação','Especialização em Gestão Pública ',''),
/*Saúde e Bem-Estar*/
(238,'Pós-graduação','Especialização em Enfermagem e Cuidado Pré Natal',''),
/*Ciências Sociais e Humanas*/
(239,'Graduação','Licenciatura em Pedagogia',''),

/*Engenharia e Produção*/
(240,'Graduação','Microeletrônica',''),
(241,'Graduação','Instalações Eletricas',''),
(242,'Graduação','Controle de Obras',''),
/*Comunicação e Informação*/
(243,'Graduação','Automação de Escritórios e Secretariado ',''),
/*Biológicas*/
(244,'Graduação','Biologia',''),
/*Artes*/
(245,'Graduação','Artes Cênicas',''),

(246,'Graduação','Editoração',''),

(247,'Graduação','Economia','');

GO

SET IDENTITY_INSERT TB_CURSO OFF;

GO