# 🏁 Telemetria FH6 - Tactile ShiftLight & Dev Station

![C#](https://img.shields.io/badge/C%23-.NET%20Framework-blueviolet?style=for-the-badge&logo=csharp)
![XInput](https://img.shields.io/badge/Hardware-XInput%20Controller-green?style=for-the-badge)
![UI](https://img.shields.io/badge/Theme-Midnight%20Dark%20%26%20Neon-cyan?style=for-the-badge)

Uma aplicação de alta performance desenvolvida em C# para **Forza Horizon 6**, projetada para extrair dados de telemetria via UDP (60Hz) e convertê-los em feedback tátil brutal no seu controle (Xbox, GameSir, etc.) através da API nativa do XInput.

O projeto conta com uma interface moderna **Midnight Dark & Neon**, suporte multilíngue dinâmico e uma central oculta de engenharia protegida por autenticação em nuvem.

---

## 🚀 Principais Funcionalidades

*   **Motor UDP Assíncrono de Alta Velocidade:** Otimizado com processamento em paralelo (`BeginInvoke`) para ler o fluxo massivo de dados do Forza sem encher o buffer de rede, evitando o clássico *Crash to Desktop* do jogo.
*   **ShiftLight Tátil Customizável:** Sinta o ponto exato de troca de marcha diretamente nos motores de vibração do controle.
    *   *Estilos de Alerta:* Contínuo, Pulso Rápido, Pulso Longo e Crescente (Rampa de RPM).
*   **Filtro de Terreno (Reduced Game Vib):** Isola e limpa os ruídos de vibração gerados pelo próprio mapa do jogo para dar prioridade total aos alertas de rotação de motor.
*   **Suporte Multilíngue:** Tradução em tempo real de toda a interface entre **Português (PTBR)** e **English (EN)**.
*   **Persistência de Dados:** Configurações de rede salvas de forma automática no arquivo local estável `MrGeH.config`.

---

## 🛠️ Central de Diagnóstico Avançada (Modo DeV)

O aplicativo possui um ecossistema oculto voltado para testes de hardware e engenharia de software, acessível pelo painel de opções e protegido por **Autenticação Baseada em Nuvem**:

1.  **Segurança Remota:** O validador se conecta à internet e lê um arquivo de texto bruto (`RAW`) hospedado de forma segura no GitHub. Isso permite alterar a chave de segurança instantaneamente sem a necessidade de recompilar o executável.
2.  **Bancada de Teste XInput:** Controle analógico individualizado dos motores de vibração:
    *   *Motor Esquerdo:* Frequência grave (simulação de peso/terreno).
    *   *Motor Direito:* Frequência aguda (simulação de RPM/*clipping*).
3.  **Simulador de Telemetria (UDP Data Spoofing):** Injeta pacotes falsos na rede local simulando perfeitamente a estrutura de memória do Forza Horizon 6. **Permite testar o aplicativo e o comportamento do controle sem precisar abrir o jogo!**

---

## 📦 Como Configurar e Jogar

### 1. No Aplicativo
1. Execute o `TelemetriaFH6.exe`.
2. Vá em **Opções** / **Options**.
3. Defina a Porta desejada (Recomendado: `5567` ou `9000` para evitar conflitos de rede do Horizon).
4. Clique em Salvar e, na tela principal, clique em **Iniciar Escuta**.

### 2. No Forza Horizon 6
1. Vá em **Configurações** $\rightarrow$ **HUD e Elementos de Tela**.
2. Role até as opções finais de Telemetria e configure:
   * **Dados de Telemetria por Cópia (Data Out):** `Ativado` (On).
   * **Endereço de IP de Dados (Data Out IP):** `127.0.0.1` (Se estiver jogando no mesmo PC).
   * **Porta de Dados (Data Out Port):** `5567` (A mesma configurada no app).

---

## 💻 Estrutura do Código

O projeto foi modularizado para garantir fácil manutenção e separação de conceitos:

*   `Form1.cs`: Janela principal responsável pelas Threads assíncronas de escuta UDP e bombardeio de comandos XInput de alta frequência.
*   `FormOptions.cs`: Painel de controle de idioma, IP, portas e gateway para o ecossistema Dev.
*   `FormPassword.cs`: Interface de login integrada com requisições HTTP silenciosas de validação remota.
*   `FormDevTest.cs`: Central de diagnósticos, timers de 60Hz e injeção de pacotes via Loopback local.
*   `ConfigManager.cs`: Arquitetura de entrada e saída (I/O) de arquivos de configuração.

---

## 👨‍💻 Créditos & Contato

Desenvolvido por **MrGeH**.

*   **Discord:** `mrgeh`
*   **Role:** Analista de Infraestrutura & Desenvolvedor

*Sinta-se à vontade para abrir uma Issue para reportar bugs ou sugerir novas features de física para o motor de vibração!*