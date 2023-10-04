/* Tratando com data e hora - DateTime
 * 
 * DateTime é uma Struct
 * 
 * Representa um monento no tempo expresso como uma data e hora
 * Uma varíavel do tipo DateTime é um tipo de valor e possui um valor padrão
 * 
 * O valor padrão de um DateTime é: 01/01/0001 00:00:00
 * Ao usar DateTime a representação para o português do Brasil usa o formato:
 * dd/mm/aaaa hh:mm:ss
 * 
 */

Console.WriteLine($"## Struct DateTime ##\n");

/* Obtendo uma data e hora */
DateTime dataAtual = DateTime.Now;
/* Exibe a representação da data e hora local formatada e expressa como: 
 * 04/09/2022 11:25:10 */
Console.WriteLine($"Data atual - {dataAtual} \n");


/* Criando uma data e hora especifica - formato (aaaa, mm, dd) */
DateTime dataEspecifica = new DateTime(1988, 02, 20);
Console.WriteLine($"Data especifica - {dataEspecifica}");
/* Pegando a data do mês passado */
DateTime dataMesPassado = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
Console.WriteLine($"Data de um mês antes - {dataMesPassado} \n");


/* Para definir a data e a hora usamos o formato (aaaa,mm,dd, hh, mm, ss) */
DateTime dataEHoraEspecifica = new DateTime(1988, 09, 04, 00, 30, 03);
Console.WriteLine($"Data e hora especifica - {dataEHoraEspecifica}  \n");


/* 
 * Extrair informações como dia, mês, hora, ano etc 
 * Year, Month, Day, Hour, Minute, Second, Millisecond
 */
DateTime hoje = DateTime.Now;

/* Extrair o ANO */
Console.WriteLine($"ANO: {hoje.Year}");

/* Extrair o MES */
Console.WriteLine($"MÊS: {hoje.Month}");

/* Extrair o DIA */
Console.WriteLine($"DIA: {hoje.Day}");

/* Extrair a HORA */
Console.WriteLine($"HORAS: {hoje.Hour}");

/* Extrair o MINUTOS */
Console.WriteLine($"MINUTOS: {hoje.Minute}");

/* Extrair o SEGUNDO */
Console.WriteLine($"SEGUNDOS: {hoje.Second}");

/* Extrair MILISEGUNDO */
Console.WriteLine($"MILISEGUNDOS: {hoje.Millisecond}\n\n");


/* 
 * Adicionar dias, horas, mês, anos, etc. 
 * AddDays, AddHours, AddMonths, AddYears
 */

/* Adicionar DIAS */
Console.WriteLine($"Add dias + 30 dias: {hoje.AddDays(30)}");

/* Adicionar MES */
Console.WriteLine($"Add mês + 1 mês: {hoje.AddMonths(1)}");

/* Adicionar HORAS */
Console.WriteLine($"Add horas + 2 hora: {hoje.AddHours(2)}");

/* Adicionar ANOS */
Console.WriteLine($"Add anos + 5 anos: {hoje.AddYears(20)}\n\n");

/* 
 * Obter dia da semana e do ano 
 * DayOfWeek, DayOfYear
 */

/* Dia da semana */
Console.WriteLine($"Dia da semana: {hoje.DayOfWeek}");

/* Dia do ano */
Console.WriteLine($"Dia do ano: {hoje.DayOfYear}\n\n");

/* 
 * Expressar data no formato longo e abreviado
 * ToLongDateString, ToShortDateString
 */

// Traz por escrito o dia o mes e o ano ex:
// 'terça-feira, 3 de outubro de 2023'
Console.WriteLine($"{hoje.ToLongDateString()}");
// Traz a data numeral ex:
// '03/10/2023'
Console.WriteLine($"{hoje.ToShortDateString()}\n\n");

/* 
 * Expressar hora no formato longo e abreviado
 * ToLongHourString, ToShortHourString
 */

// Traz a hora, minuto, segundo
Console.WriteLine($"{hoje.ToLongTimeString()}");
// Traz a hora, minuto
Console.WriteLine($"{hoje.ToShortTimeString()}\n\n");



Console.ReadKey();