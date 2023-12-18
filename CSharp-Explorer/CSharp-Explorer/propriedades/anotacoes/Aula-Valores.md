# Manipulando vetores

### Concatenando strings
Podemos formatar valores em diversas representações. Essa formatação de valores é conhecida por concatenação ou 
interpolação.

### Formatando DateTime
DateTime data = Datetime.now; // pega o horário do seu sistema
Retorna tanto data e hora

data.ToString("dd/MM/yyyy HH:mm"); // retorna data e hora formatado
data.ToShortDateString() // retorna somente a data formatada dd/MM/yyyy
data.ToShortTimeString() // retorna somente a hora formatada HH:mm

