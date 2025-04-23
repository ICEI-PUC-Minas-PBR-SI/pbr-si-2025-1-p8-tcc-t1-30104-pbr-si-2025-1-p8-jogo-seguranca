<span style="color:red">**Pré-requisitos:** [Introdução](1-Introdução.md)</span>

# Trabalhos Relacionados

Com base no contexto apresentado, há diversas iniciativas que se baseiam em criar jogos que, de forma lúdica, ensinam as pessoas e conseguem reter sua atenção. Nos próximos parágrafos serão apresentados alguns trabalhos que, assim como este, visam trazer conhecimento de uma forma diferente das utilizadas comumente.

Um dos trabalhos relevantes neste contexto é o **CyberLearn2D**, um jogo educacional desenvolvido com base na Aprendizagem Baseada em Jogos Digitais (DGBL), cujo principal objetivo é ensinar conceitos fundamentais de cibersegurança por meio de desafios interativos (Piki; Stavrou; Procopiou, 2023). O jogo apresenta uma série de cenários que simulam ataques cibernéticos comuns, como phishing, engenharia social e ataques de força bruta, incentivando os jogadores a analisarem situações e tomarem decisões para evitar violações de segurança. 

Durante o jogo, os usuários enfrentam desafios práticos, onde precisam reconhecer ameaças, responder corretamente e compreender as consequências de suas ações dentro do ambiente virtual. A principal semelhança entre o CyberLearn2D e este estudo está na utilização da gamificação como ferramenta de conscientização sobre segurança digital. Ambos os projetos compartilham a premissa de que o aprendizado se torna mais eficaz e envolvente quando apresentado por meio de jogos interativos.

No entanto, os dois projetos se diferenciam em sua abordagem visual e mecânica de interação. Enquanto o CyberLearn2D adota uma perspectiva 2D, utilizando gráficos mais simples e uma mecânica baseada em escolhas de múltipla escolha e desafios textuais, o presente estudo explora um ambiente tridimensional isométrico, proporcionando uma experiência mais imersiva e dinâmica.

A pesquisa conduzida por Criollo-C et al. (2024) analisou a eficácia do **CiberSecApp**, um jogo educacional voltado para o ensino de conceitos fundamentais de cibersegurança. O CiberSecApp foi desenvolvido como um aplicativo móvel gamificado, com o objetivo de incentivar o aprendizado por meio da interação ativa e do engajamento dos usuários. 

Diferente de abordagens tradicionais baseadas em palestras e materiais textuais, a aplicação utiliza dinâmicas de jogo, desafios e recompensas para tornar o ensino de segurança digital mais acessível e envolvente. O estudo não se limitou apenas ao desenvolvimento do jogo, mas incluiu uma avaliação detalhada da usabilidade e da carga cognitiva imposta aos jogadores. 

Para isso, os pesquisadores aplicaram métricas como o System Usability Scale (SUS) e ferramentas de análise de workload, permitindo uma compreensão aprofundada sobre a experiência do usuário e o impacto do jogo no processo de aprendizado. Os resultados indicaram que a gamificação pode melhorar a assimilação de conceitos de cibersegurança, tornando os usuários mais conscientes sobre boas práticas de segurança digital.

Esse estudo é altamente relevante para o presente trabalho, pois compartilha a mesma premissa central: o uso de jogos digitais como ferramenta educacional para cibersegurança. No entanto, enquanto o CiberSecApp foca na avaliação da usabilidade e na carga cognitiva, o presente estudo busca ampliar a abordagem, incluindo métricas mais abrangentes, como a retenção do conhecimento ao longo do tempo e a análise do comportamento dos usuários antes e depois da experiência gamificada.

Outro trabalho relevante para este estudo é a pesquisa de Toledo, Louis e Sengupta (2024), que apresenta o **NetDefense**, um jogo educacional do gênero Tower Defense projetado para ensinar conceitos fundamentais de cibersegurança a estudantes do ensino fundamental e médio. O objetivo principal do NetDefense é fornecer um ambiente interativo e gamificado que permita aos alunos compreender melhor a importância da defesa de redes, utilizando conceitos como pacotes de dados, firewalls, filtragem de tráfego e honeypots.

O jogo se destaca por adotar uma abordagem inovadora, na qual os jogadores devem posicionar roteadores e firewalls estrategicamente para bloquear ataques cibernéticos simulados por pacotes de dados maliciosos. O presente trabalho compartilha o propósito do NetDefense ao utilizar a gamificação para ensinar cibersegurança de maneira interativa. 

No entanto, há diferenças importantes entre os dois projetos. Enquanto o NetDefense é voltado para o ensino fundamental e médio, a proposta do **CyberWar** busca alcançar tanto usuários comuns quanto profissionais em ambientes corporativos. Além disso, o NetDefense foca na defesa de redes por meio de mecânicas estratégicas de Tower Defense, enquanto o jogo desenvolvido prioriza a conscientização sobre ameaças digitais, como engenharia social e phishing, enfatizando o impacto do fator humano na segurança digital.

---

# Fundamentação Teórica

Este referencial teórico tem como objetivo apresentar os principais conceitos que embasam a proposta deste trabalho, abordando métodos de ensino contemporâneos, o uso de jogos digitais como estratégia educacional e fundamentos sobre cibersegurança. A seguir, são exploradas as bases teóricas que sustentam a aplicação da gamificação no ensino de temas relacionados à segurança digital.

## Métodos de Ensino

A educação tem passado por grandes transformações nas últimas décadas, principalmente devido à evolução tecnológica e às novas descobertas sobre o funcionamento do aprendizado humano. O modelo tradicional de ensino, baseado na transmissão passiva de conhecimento pelo professor e na memorização por parte do aluno, tem demonstrado diversas limitações no processo de aprendizagem (Zhao; Muntean; Chis; Rozinaj, 2022).

Por outro lado, os métodos modernos de ensino, como a **aprendizagem baseada em jogos (GBL)**, têm se mostrado mais eficazes em engajar os estudantes e melhorar sua motivação. Um estudo realizado por Lopez-Fernandez et al. (2021) comparou o ensino tradicional com a GBL em cursos de ciência da computação, utilizando jogos criados por professores. Os resultados demonstraram que, embora ambos os métodos fossem igualmente eficazes na aquisição de conhecimento, a GBL foi significativamente superior em aumentar a motivação dos alunos.

Essas metodologias modernas enfatizam o contato direto com o domínio de estudo, estimulando o aprendizado através da experiência, experimentação e resolução de problemas reais. O aprendizado ativo, promovido por essas abordagens, incentiva a criatividade, o pensamento crítico e a retenção de conhecimento a longo prazo.

## Abordagens de Ensino com Jogos Digitais

Os jogos digitais têm sido amplamente utilizados como ferramentas educacionais, e diferentes abordagens foram desenvolvidas para integrar esses jogos ao aprendizado. Entre as principais estratégias, destacam-se:

- **Aprendizagem Baseada em Jogos Digitais (DGBL)**: envolve o uso de jogos como meio de ensino, proporcionando uma experiência interativa e imersiva (Sreehari et al., 2023). Nessa abordagem, os conceitos educacionais são incorporados diretamente à mecânica do jogo.
- **Jogos Sérios**: desenvolvidos com um propósito educacional explícito, indo além do entretenimento. Abordam temas como segurança cibernética, medicina e direito (Santiago et al., 2023).
- **Gamificação**: aplicação de elementos de design de jogos em contextos não relacionados a jogos, como pontos, medalhas e rankings, para aumentar o engajamento e a motivação (Afonso; Rodrigues; Reis; Miller, 2021).

O jogo desenvolvido neste trabalho se enquadra na categoria de DGBL, pois utiliza técnicas interativas para ensinar conceitos essenciais de cibersegurança de maneira envolvente e prática. Através da gamificação, elementos como desafios, recompensas e feedback imediato incentivam o engajamento e a assimilação dos conteúdos.

## Cibersegurança

A cibersegurança, ou segurança cibernética, refere-se aos métodos e tecnologias adotadas para proteger sistemas, redes, dispositivos e dados contra ataques digitais, acessos não autorizados, danos ou roubo de informações (Nasution; Lubis; Saedudin, 2024). Seu objetivo é assegurar a **confidencialidade, integridade e disponibilidade** das informações no ambiente digital.

## Ataques Cibernéticos

Os ataques cibernéticos são ações maliciosas com o objetivo de comprometer a segurança de sistemas e redes. Dentre os principais tipos:

- **Engenharia Social**: manipulação psicológica para obtenção de dados sensíveis (Nasution; Lubis; Saedudin, 2024).
- **Man-in-the-Middle (MitM)**: interceptação de comunicação entre dois dispositivos, com roubo ou modificação de dados (Saed; Aljuhani, 2024).
- **Phishing**: tentativa de enganar usuários com mensagens ou sites falsos, visando roubar credenciais, senhas ou dados bancários.

Para mitigar esses riscos, recomenda-se o uso de **criptografia ponta a ponta**, **autenticação multifator**, **VPNs**, **filtros de e-mail** e **treinamentos de conscientização**.

---
