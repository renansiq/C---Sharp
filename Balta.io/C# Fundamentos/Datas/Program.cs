// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();
//var data = new DateTime(2022, 10, 12, 8, 0, 12);

var data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.Year);
Console.WriteLine(data.Month);
Console.WriteLine(data.Day);
Console.WriteLine(data.Hour);
Console.WriteLine(data.Minute);
Console.WriteLine(data.Second);
Console.WriteLine((int)data.DayOfWeek);
Console.WriteLine(data.DayOfYear);

// padrões de formatação

// Y = year  MM = month   mm = minutes  dd = Day  hh = Hour  ss = Second
var formatada = String.Format("{0:yyyy}", data);
Console.WriteLine(formatada);

formatada = String.Format("{0:MM}", data);
Console.WriteLine(formatada);

formatada = String.Format("{0:mm}", data);
Console.WriteLine(formatada);

formatada = String.Format("{0:dd}", data);
Console.WriteLine(formatada);

formatada = String.Format("{0:hh}", data);
Console.WriteLine(formatada);

formatada = String.Format("{0:ss}", data);
Console.WriteLine(formatada);

// ff = fração de segundo     z / zz / zzz = timezone 
formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff zzz}", data);
Console.WriteLine(formatada);

formatada = String.Format("{0:d}", data);    // menor data a ser exibida
Console.WriteLine(formatada);

formatada = String.Format("{0:T}", data);    // Tempo longo
Console.WriteLine(formatada);

formatada = String.Format("{0:t}", data);    // Tempo longo
Console.WriteLine(formatada);

formatada = String.Format("{0:R}", data);    // padrão
Console.WriteLine(formatada);

formatada = String.Format("{0:s}", data);    // padrão
Console.WriteLine(formatada);

formatada = String.Format("{0:u}", data);    // padrão
Console.WriteLine(formatada);

// adicionando valores
Console.WriteLine(data.AddDays(3));
Console.WriteLine(data.AddMonths(2));
Console.WriteLine(data.AddYears(15));
Console.WriteLine(data.AddMinutes(75));
Console.WriteLine(data.AddSeconds(2));

//comparando datas
//DateTime? data = null;
var data2 = DateTime.Now;

// if (data.Date >= DateTime.Now.Date)
if (data.Date == DateTime.Now.Date)
    Console.WriteLine("São iguais");
else
    Console.WriteLine("São diferentes!");

Console.WriteLine(data2);

// globalização (CultureInfo)

var pt = new CultureInfo("pt-PT");
var br = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");

Console.WriteLine(DateTime.Now.ToString("D", de));

var atual = CultureInfo.CurrentCulture.Name;

Console.WriteLine(DateTime.Now.ToString(atual));

// Timezone

var dateTime = DateTime.UtcNow;

Console.WriteLine(DateTime.Now);
Console.WriteLine(dateTime);

Console.WriteLine(dateTime.ToLocalTime());

var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine(timezoneAustralia);

var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
Console.WriteLine(horaAustralia);

var timezones = TimeZoneInfo.GetSystemTimeZones();
/* foreach (var timezone in timezones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
    Console.WriteLine("-------");
} */


// timeSpan   - aritimética sobre datas
var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanosegundos = new TimeSpan(1);
Console.WriteLine(timeSpanNanosegundos);

var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
Console.WriteLine(timeSpanHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

// funções úteis
Console.WriteLine(DateTime.DaysInMonth(2022, 4));  // quantos dias tem o mês?
Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));   // é sábado ou domingo? - retorna uma bool
Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // se a hora está em formato horário de verão - booleano

static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}



