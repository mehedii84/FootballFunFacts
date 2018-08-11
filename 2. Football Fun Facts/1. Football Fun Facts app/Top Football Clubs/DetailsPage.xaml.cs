using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GoogleAds;
using System.Diagnostics;

namespace Top_Football_Clubs
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }


        private void OnAdReceived(object sender, GoogleAds.AdEventArgs e)
        {
            Debug.WriteLine("Received ad successfully");
        }

        private void OnFailedToReceiveAd(object sender, GoogleAds.AdErrorEventArgs errorCode)
        {
            Debug.WriteLine("Failed to receive ad with error " + errorCode.ErrorCode);
        }



        int teamCounter;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string msg = "";

            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
            {
                teamCounter = int.Parse(msg);
               

            }


        }

        private void showText_Loaded(object sender, RoutedEventArgs e)
        {
            if (teamCounter == 0)
            {
                showText.Text = @"1. Chelsea (jointly with Arsenal) were the first clubs to play with numbered shirts - on 25 August 1928 in their match against Welsh side Swansea City.

2. Chelsea's highest appearance-maker is Ron Harris, who played in 795 first-class games for the club between 1961 and 1980.

3. With 86 caps, Frank Lampard is Chelsea's most capped international player.

4. Bobby Tambling is Chelsea's all-time top goal scorer, with 202 goals in 370 games (1959–70).

5. Chelsea hold the record for the highest ever points total for a league season (95) and the fewest goals
conceded during a league season (15) - under the management of Jose Mourhino in 2004/05.

 6. Chelsea became the first British side to field an entirely foreign starting line-up in a Premier League match - against Southampton in December 1999.

7. The club's 21–0 victory over Jeunesse Hautcharage in the UEFA Cup Winners’ Cup in 1971 remains a record in European competition.

8. On 19 May 2007, they became the first team to win the FA Cup at the new Wembley Stadium.

9. Chelsea hold the record for the longest streak of unbeaten matches at home in the English top-flight, which lasted 86 matches from 20 March 2004 to 26 October 2008.

10. Chelsea holds the record for the highest home attendance match - against Arsenal with an attendance of 82,905 on the 2 October 1935.

11. Chelsea's mascot is a lion taken from their club logos and named Stamford The Lion. In July 2005 the costume was stolen from Stamford Bridge. ";


                
            
            
            }

            else if (teamCounter == 1)
            {
                showText.Text = @"1. The oldest player to play in the Premiership was Manchester City goalkeeper John Burridge, who was 43 years, 4 months and 26 days when he came on as a half time substitute for Manchester City v Newcastle United on April 29, 1995.

2. In 1906, only a few years after Manchester City won the FA Cup, a large portion of their team was suspended due to financial irregularities. Not much is known about the specifics of this situation, but seventeen players were placed on suspension, severely hampering the team’s ability to compete.

3. In 1937-38, they managed to become the only club ever to be relegated with a positive goal difference (80-77).

4. Man City’s most successful run was in 1969 to 1970’s when they won the FA Cup (1969), European Cup Winners’ Cup (1970) and the League Cup (1970).

5. Manchester City have only twice held the British transfer record, once for Steve Daley in 1979 from Wolverhampton Wonderers for £1,180,000 and latterly, Robinho from Real Madrid in 2008 for £32,500,000.

6. Youngest Player who ever played for City was Glyn Pardoe, who was 15 years 314 days (against Birmingham City, First Division) in 1962.

7. City won their first FA cup in 1904.

8. City once won the Old European-Cup winners Cup in 1970 under Joe Mercer, who later become City’s most memorable and successful manager.

9. Manchester City scored over a hundred goals in 1957/58, only to concede a 100 goals in the same season.

10. For the first seven years of their history, Manchester City were known as Ardwick FC.

11. Eric Brook is City’s all time top

Eric Brook is City’s all time top scorer with 178 goals in 494 appearances.";
            }


            else if (teamCounter == 2)
            {
                showText.Text = @"1) Arsenal are nicknamed 'The Gunners' because they were formed by a group of cannon makers at the Woolwich Arsenal in 1886.

2) Arsenal is the only league team still in existence that has never been relegated.Arsenal has been in top flight English football since 1919-1920.

3) Arsenal completed the 2003–04 FA Premier League campaign unbeaten. Their league record was 26 wins, 12 draws and 0 losses, over 38 games in total.
Continuing into the 2004-05 season, Arsenal eventually went 49 Premier League games unbeaten, which was a new record for the most  consecutive league games without defeat, the sequence coming to an end  with a controversial 2–0 defeat to Manchester United.

4) The Premier League commissioned a special gold version of the Premier League trophy to commemorate Arsenal's achievement.

5) Arsene Wenger became the first foreign manager to lift the Premiership title, when Arsenal won it in the season of 1997-98.

6) Arsenal is the first English team to beat Real Madrid at Santiago Bernabeu, Bayern Munich at Allianz Arena and AC Milan at San Siro.

7) Arsenal are the first and only British side to defeat both Milanese teams 'FC Internazionale' and 'AC Milan' at the San Siro - 5-1 (UEFA Champions  League group stage , 25 November 2003), 2-0 (UEFA Champions League second round second leg, 4 March 2008) respectively.

8) Arsenal became the first team to win the League Cup and FA Cup in the same year, 1993.

9) Arsenal has the record of keeping a clean sheet for 10 consecutive Champions League matches. They went exactly 995 minutes without conceding a goal.

10) Arsenal’s match against Sheffield United on 22nd January 1927 at Highbury, was the first ever English league match to be broadcasted on the radio. An exhibition match between their first team and the reserves held on 16th September 1937 was the first ever football match to be televised live.";

            }


            else if (teamCounter == 3)
            {
                showText.Text = @"Ryan Giggs almost signed for Man City. United grabbed from under their noses.

Since the inception of the Premier League, Manchester United have accumulated 1503 points from wins - winning 86 more games than nearest rivals Arsenal.

The famous five of Manchester United's youth academy - Ryan Giggs, Paul Scholes, David Beckham, Gary Neville and Nicky Butt - appeared 3038 times in total for the Red Devils.

Last season alone, Manchester United had 20 players out on loan.

Sir Matt Busby only bought 16 players in his 13 years in charge of United before Munich. 4 of them were Goal Keepers. He didn't buy anyone in the period between 1953-57.

Manchester United FC's very existance was once saved by a wondering dog.

Our first game at Old Trafford was against Liverpool in 1910. Sadly, they won that day. United's first European game at Old Trafford was against Anderlecht, we won 10-0. 

Manchester City allowed United to play their first-team games at Maine Road following bomb damage to Old Trafford during the second world war.

Bobby Charlton still holds the record as highest Manchester United goalscorer, with 249 goals in all competitions.

Despite his natural goalscoring talent and legendary status at the club, Charlton is quoted as saying that Duncan Edwards is the ""only player that made me feel inferior""

Sir Matt Busby played his entire professional career for United's two greatest modern day rivals, Liverpool and Manchester City.

The last time United played outside the top flight of English league football, was in the '75/76 season under Tommy Docherty. He was sacked the following season.
Under Sir Alex Ferguson, we never finished lower than 3rd in the Premier league.

 The 1999 Treble winning season made United the second British team to achieve the feat (after Celtic in 1967) as well as the first (and so far, only) English team to win it, and one of only 7 European clubs thus far.

The shortest runout any of our players have had in one match was Chris Smalling - who played 12 seconds vs Norwich in 2012.

";

                showText1.Text = @"Ryan Giggs holds the record for most United appearances. He has played more English Premier League games than Manchester City.

Giggs also holds the record for fastest goal scored by United, netting after 15 seconds vs Southampton in 1995.

Dimitar Berbatov remains our record signing, costing £30.75 million in 2008, Rio Ferdinand a close second at £29.1 million.

 The most we've received for a departing player is £80 million for Cristiano Ronaldo, with David Beckham second a relative bargain at £25 million.

Wayne Rooney is the highest scoring Englishman in Champions League history, a record once held by Paul Scholes.

United's top ten all-time scorers are British.

Manchester United are top of the all-time Premier League table, some 250 points clear of Arsenal.

We've never had a non-British manager.

Under the management of Sir Matt Busby, Manchester United took the intimidating nickname, the ‘Red Devils’, from Salford Rugby Club, who toured France under the same name whilst also wearing red shirts.

The longest period without an Irish man in the first team is 6 months.";

            }


            else if (teamCounter == 4)
            {
                showText.Text = @"The very first Liverpool Football Club was created in 1857 and played to a code similar to rugby union. However, it has no relation with the modern version of the club that is in existence today.

They are noted to be one of the oldest established rugby clubs in the world and later went on to merge with Liverpool St. Helens FC.

Anfield was the original home of Everton FC in 1884, but after a rent dispute, Everton decided to move to Goodison Park in 1891.

John Houlding, the lease holder of Anfield, was left with a stadium and no team, so the board went to Scotland and signed 13 players to form the new Liverpool Football Club in 1892.

The club's original strip was blue and white quarters.

Liverpool's first ever game was against Rotherham Town. They won the match 7-1 with Malcom Macvean scoring their first ever goal. That game was also the first time an English domestic team had fielded a side consisting entirely of foreign players.

Despite a 20,000 capacity stadium, Liverpool's first game was watched by just 100 supporters.

After being rejected by the Football Association, Liverpool played in the Lancashire League. Their first game was an 8-0 victory against Higher Walton with John Smith scoring Liverpool's first ever competitive goal.

They ended the season as champions, beating Everton 1-0 in the first ever Mersyside Derby.

The Merseyside derby has the highest amount of players sent off than any other Premier League fixture.

Liverpool were elected in to the Football Association in 1893.

Their first professional season saw the club become second division champions and going the whole campaign unbeaten, with Malcom Maclean once again scoring their first ever goal.

It also included a 2-0 victory over Newton Heath, later to be known as Manchester United.

The strip changed from blue and white quarters to red and white.

";


                showText1.Text = @"In 1901, Alex Raisbeck was the first Liverpool captain to collect the Football League first division championship, under the management of Tom Watson.

Expansion of the South end of Anfield in 1906 created a larger stand called the Spion Kop, named after a Boer war battle of 1900 where over 300 men of the Lancashire regiment died, with many being from Liverpool.

The Spion Kop was the biggest in the country at the time and could hold more standing supporters than some entire football stadiums.

Liverpool played their first ever FA Cup final in 1914 with a 1-0 loss to Burnley at Crystal Palace, the last time the event would ever be held there.

1915 saw Liverpool involved in one of the sports earliest betting scandals, with four Liverpool players being banned.

Don Welsh took charge in 1951 and Liverpool were relegated for the first time in over 50 years.

After not being able to return Liverpool to the top tier, for the first time in Liverpool's history, they sacked their manager, Don Welsh, in 1956.

Liverpool spent eight seasons in division two between 1954 and 1962.

In 1959, Liverpool suffered their most humiliating defeat up to that point with an FA Cup exit to non-league side Worcester City. This loss is said to have contributed to the exit of the manager a the time, with a man named Bill Shankley taking over the club.

After winning promotion back in to the first division, Shankley finished eighth in the league. Since that date, Liverpool have never finished below eighth and never played outside of the top flight.

In 1964 Liverpool changed their strip from red and white to the current all red that is seen today.

A local factory threatened to go on strike when Bill Shankley said he will be resigning in 1974.

Bob Paisley was in charge for nine years and his first in 1974-75 was Paisley's only season without a trophy.

Bob Paisley won a total of 21 trophies in his nine years at the club, making him Liverpool's most successful manager and one of the most successful managers at an English club.

Joe Fagan became manager in 1984 and in his first season he led Liverpool to the League title, the League Cup and the European Cup—the first time an English club had won three trophies in a season.

Grahame Souness bought Dean Saunders from Derby County for a British record fee at the time of £2.9 million.

Dean Saunders was very successful for the club but he was surprisingly sold to Aston Villa a season and six matches later at a loss of £400,000.

In March 1992, ex Liverpool player and manager, Grahame Souness, suffered a heart attack which required a triple bypass operation. On his recovery, Souness sold his story to The Sun newspaper.

When ex player, Roy Evans took over from Souness, he had been on the club's payroll for close to 30 years.

Michael Stensgaard, a signing of Roy Evans, never played for the first team and had to retire from football altogether after injuring himself setting up an ironing board.
";




                showText2.Text = @"Roy Evans introduced the 3-5-2 formation in 1994, which would apparently revolutionise the English game with many other teams adopting the formation soon after.
After the semi-final victory over Chelsea on the way to Istanbul in 2005, the match referee stated that he would have sent off Petr Cech for his foul on Milan Baros and given a penalty if the linesman had not given the goal.

Liverpool lost the World Club Championship final in 2005 to Sao Paulo 1-0, despite having three goals disallowed for offside.

In February of 2006, Liverpool ended an 85 year run of losses against Manchester United in the cup by beating them 1-0 at Anfield. The first victory over United in the FA Cup since 1921.

Liverpool went on to complete their biggest ever away victory in the competition with a 7-0 win over Birmingham.

In 2005-06 Liverpool finished the league with the biggest points tally by a third placed team as well as their highest amount since 1988 with 82 points.

In the 2007-08 season, Liverpool recorded the biggest ever Champions League margin with an 8-0 victory over Besiktas.

In April of 2008, Forbes magazine ranked Liverpool as the fourth most valuable club in the world.

August 22nd 1964 and highlights of Liverpool vs Arsenal was the very first match to be shown on the BBC's new football programme, Match of The Day.

The very first colour football transmission was of the live game between Liverpool and West Ham.

Liverpool supporters singing ''You'll Never Walk Alone'' was featured in the Pink Floyd song, Fearless.

Robbie Fowler holds the club and Premier League record for the fastest hattrick standing at 4 minutes and 32 seconds.

Kenny Dalgleish was the first player-manager in English football in 1985.

Liverpool's Xabi Alonso holds the English record for the longest goal scored from open play standing at 64 metres.

Liverpool are the only team unbeaten at home in 2008.";


            }


            else if (teamCounter == 5)
            {
                showText.Text = @"1. On October 22, 1899, Hans Kamper placed an advertisement in a local newspaper claiming his wish to form a football club; a few positive 
answers led to a meeting at the Gimnasio Solé on November 29th. Eleven players attended, led by Joan Gamper. FC Barcelona was created.

2. Supporters of FC Barcelona are called “culés”, coming from the word for bum in Catalan. According to legend, from outside the old Les Corts stadium, all that could be seen of the spectators in the stands was their backsides!

3. Barcelona´s Camp Nou was once the same size as the Maracanã Stadium in Rio de Janeiro, Brazil and the largest stadium in the world with capacity for 120, 000 spectators. It has since been reduced in size for security reasons. 

4. The first official match took place in the Camp Nou on the 6th October 1957 against Real Jaén. The result was a win for FC Barcelona with 6 goals to 1. 

5. The large roof of the Camp Nou slows down the growth of the gras son the field and has to be regularly changed.

6. The motto of the club, “Mes que un Club” was a symbol of Catalan nationalism especially during Franco´s dictatorship.

7. Under Franquismo, the Catalan language and symbols were banned. In 1939, the football team was also forced to change their name to Club de Football Barcelona. The Catalan flag was removed form the shield of the club. Yet, at this time, the Stadium remained one of the rare places where Catalan could be spoken and Catalan flag could be shown freely.

8. It was only in 1974 when the club changed its name back to Futbol Club Barcelona.

9. The President of the FC Barcelona, Joan Laporta, a self-proclaimed nationalist, requires all foreign players to learn Catalan. Yet, some famous players are not required to speak it such as Lionel “Leo” Messi, who spoke Catalan once, when he was drunk after a FC Barcelona win, and through a megaphone.

10. In 2007, Laporta dedicated some tickets for the FC Barcelona vs. Real Madrid game to Federació Lull, an organization which promotes the spread of the Catalan language.";



                showText1.Text = @"11. On July 14th, 2006 the club signed an agreement with Unicef that included the organization´s logo for the first time in the club history. The FC Barcelona donated €1.5 million each year to the organization as part of the 5-years agreement.

12. FC Barcelona is the football club with the most Ballon d´or winners in the world –a prize granted to the best football player of the year, worldwide- with 10 cups.
In 1992, the Camp Nou hosted the Olympic games and La Roja, the Spain national football team, defeated Poland 3-2.

13. We usually forget about it but FC Barcelona is not the only football club of the Catalan capital city. RCD Espanyol was founded by Spanish football fans and is against FC Barcelona, arguing that the team is full of foreigners. For long, the RCD Espanyol has been a rival of FC Barcelona; during the Franco´s dictatorship, the club cultivated the compliance to the central authority while FC Barcelona had a revolutionary spirit.

14. The two most successful Spanish football teams, FC Barcelona and Real Madrid are fierce competitors. The rivalry is said to come from Franco’s dictatorship. FC Barcelona represented an opposition to Franquismo while Real Madrid was a symbol of nationalism and was supported by the regime and the dictator itself. Yet, another explanation for such competition is that those two cities are the largest and richest in Spain. Both clubs are also the most prolific.

15. With Franco in attendance, the club defeated Real Madrid 1-0 at the Copa del Generalismo final in 1968. The club’s coach at the time, Salvador Artigas, was a Republican pilot during the Spanish Civil War.

16. There have been 227 official confrontations between the two teams since the first Clasico on May 13th, 1902 (apart from friendly matches). Real Madrid won more matches; 91 wins for Real Madrid, 88 for FC Barcelona and 48 draws. Moreover, there have been 752 goals scored during Clasicos so far with an average of 3.3 goals per game. Yet, Real Madrid FC scored more than FC Barcelona, 384 goals vs. 368 for the Catalan club.

17. This is a 3D show at the beginning of the Camp Nou stadium tour, which objective is to transmit the feeling of being on the football field thanks to real match images shown in 3D.";
       
            
            }


            else if (teamCounter == 6)
            {
                showText.Text = @"1. Real Madrid holds the record as the most effective team in the Spanish Football aspect and was voted by FIFA as the most successful club of the 20th century. 

2. Real Madrid Football Club was founded at the hands of the British embassies, along side their arch rivals, FC Barcelona.

3. A Harvard University study on football showed that Real Madrid Football Club was the most popular team in the world, with a fan base of over 228 million supporters!

4. The most unforgettable match for Real Madrid and its rival FC Barcelona was probably the one that took place in 1943, where Real Madrid defeated Barcelona 11 – 1 after having lost by 0 to 3 the previous match

5. From the mid 80's onwards, Real Madrid bounced back from its lost grasp of the La Liga title, with this generation of players nicknamed ""La Quinta del Buitre""(Vulture's Cohort) which was a name derived from one of its key members; Emilio Butrageno. They proceeded to win 5 leagues in a row which is something that no other time has been able to do till today.

6. Alfredo Di Stefano, who was a striker for Real Madrid, was said to be the best footballer of all time. Though others might disagree and say he was only the best European footballer, he and his amazing talent (31 caps) was said to be the key to making Real Madrid one of the biggest clubs in the world.

7. Real Madrid's highest home attendance was for the 2006 Copa del Ray match with a crowd of 83,329. 

8. Since its foundation, only members (Spanish) were allowed to operate and run the club as President and currently the club has an both a President and an honorary President as well. (Alfredo Di Stefano)

9. The Rivalry toward FC Barcelona extends deeper than just football history. Rather, if you dig deeper, you'll find political views and country loyalty in the mix as well. A truly interesting story!

10. Real Madrid Football Club is the second richest in the world (351m) in terms of revenue and the second most valuable club in the world to date. ";
            }


            else if (teamCounter == 7)
            {
                showText.Text = @"1. The last time Atletico reached the last four in Europe was the European Cup semi-final win against Celtic in 1974. Goals from Jose Garate and Adelardo Rodriguez saw Atletico advance 2-0 on aggregate, where they lost 4-0 in a replay of the final to Bayern Munich, the first final ended 1-1.

2. On-loan Chelsea goalkeeper, Tibhaut Courtois is in his third consecutive loan spell at Atletico. He has never played for Chelsea since his move from Genk in 2011.

3. Atletico Madrid previously had some of the world’s finest striking talent in the form Radamel Falcao, Diego Forlan, Sergio Aguero and now boast Diego Costa up front. Current Chelsea forward Fernando Torres used to be an integral part of the Atletico side between 2001 and 2007. 

4. The Vicente Calderon Stadium, home of Atletico Madrid has hosted three games from the 1982 World Cup, all Round Two, Group D matches, which ended France 1 Austria 0, Austria 2 Northern Ireland 2 and Northern Ireland 1 France 4.

5.Diego Simeone took over Atletico Madrid in December 2011. The Argentine took over Atletico when they were just four points above the relegation zone. They survived that season and in Simeone’s first full season he guided his new side to a cup treble winning the Copa Del Rey, European Super Cup and tEuropa League. 

6. The club was founded in 1903 by three Basque students living in Madrid. The founding owners saw the club as a youth branch for Atletico Bilbao, the owners’ childhood team 
7. For Atletico Madrid, this is their first ever Champions League semi-final.

8. Back in February 2008, then striker, Sergio Aguero was sent off for spitting in the second leg of a UEFA Cup last 32 contest against Bolton Wanderers – the Trotters won 1-0 on aggregate thanks to a goal from El Hadji Diouf. 
9. Atletico Madrid’s stadium is named after a former president of the club - Vicente Calderon. A man who became president in 1964 and proceeded to save Atletico from crippling financial difficulties and guide them to a golden period in their history between 1960 and 1970. After Calderon resigned from the club in 1980, there was behind the scenes instability with several interim presidents. Calderon was re-elected in 1892 but died in 1987 from a heart attack during his second term at the helm.

10. The last time Atletico Madrid won the La Liga title was back in the 1995/96 season with 87 points - four points clear of runners-up Valencia. That same season Chelsea finished 11th in the Premier League, 12 points above the relegation zone and 32 points behind winners Manchester United. That same season Manchester City got relegated to Division One along with QPR and Bolton.

";
            }


            else if (teamCounter == 8)
            {
                showText.Text = @"1)Valencia CF are the flagship club for the Valencia region and were formed in March 1919 (a good year for founding football clubs!). Their nickname is Los Ches - which means 'the Mates'.

2) They have played at their current stadium since 1923: the Estadio Mestalla is the sixth largest stadium in Spain with a capacity of 55,000. Before each game the club run out to their anthem 'Pasodoble', which is sung in the Valencian dialect.

3) Valencia should have moved to the Estadio Nuovo Mestalla (New Mestalla) in the last two years however the global recession caused the joint financing agreement with the Valencia Regional Government and local construction firms to collapse.

4) This has led to Valencia still playing in a stadium they originally agreed to sell off and owning a half built stadium they can not afford to complete. The club employ four people to occupy their half-built new stadium in order to show there is 'work' in progression, even though they can't carry out an serious construction work. Instead they watch television. By law the stadium can be taken off them if it is proved no substantial work has been undertaken on the Nuovo Mestalla.

5) Inevitably stadium problems mean that Valencia have racked up over £500 million in debt which they are still trying to service. Despite selling Spanish World Cup winning stars David Villa (Barcelona); David Silva (Manchester City), Juan Mata (Chelsea) and Carlos Marchena (Villarreal), Los Ches have failed to substantially cut the debts they own.

6) Current captain David Albelda was effectively sacked in 2007-08 season by then coach Ronald Koeman for an alleged breach of club discipline. However the club removed Koeman and reinstated Albelda in the same season, who helped Los Ches avoid relegation from the Primera Liga.

7) Valencia have only spent four years outside of the top flight during their 92 history. Most recently they spent a year in the second division in the 1986-87 season.

8) The club are the third most successful in Spain (no prizes for guessing which two clubs are above them), with six La Liga titles and seven Spanish Copa del Rey victories. Their most recent league title came under the guidance of Rafael Benitez (remember him?) in 2004, the same year they won the UEFA Cup.

9) Valencia also won the Inter Cities Fairs Cup in 1962 and 1963 and have also won the defunct European Cup Winners' Cup in 1980, defeating Arsenal in the final on penalties after a 0-0 draw. They are most famous for reaching the Champions League final in successive seasons at the turn of the millennium under Argentinean coach Hector Cuper. In 2000 they lost 3-0 to Real Madrid in Paris, whilst in 2001 a side including ex-Stoke loanee John Carew lost to Bayern Munich on penalties in Milan following a 1-1 draw. On their way to the 2001 final they beat Leeds United in the Semi-Final.

10) Famous former players for Valencia include Gaizka Mendieta, Kike, goalkeepers Santiago Canizares and Andoni Zubizaretta, Dutchmen Faas Wilkes and Johnny Rep, Brazilian striker Romario and Argentinians Ariel Ortega and Mario Kempes. In their current squad keep an eye out for Ever Banega, goal machine Roberto Soldado, Jordi Alba and Mehmet Topal.

11) Notable coaches for Los Ches include the legendary Alfredo Di Stefano (who coached them to the title in 1971), Kurt Jara, Hector Cuper and Rafael Benitez. Present incumbent Unai Emery guided Valencia to two third place finishes in the last two seasons despite the club selling their star player each year to pay off some of their debts.";
            }


            else if (teamCounter == 9)
            {
                showText.Text = @"Sevilla FC
Formed: 1905
Nickname: Los Hispalenses (from Hispalis, Seville's ancient name), Los Blanquirrojos (white-and-reds)
UEFA club competition honours (runners-up in brackets)
• UEFA Cup/UEFA Europa League (3): 2006, 2007, 2014
• UEFA Super Cup (1): 2006, (2007), (2014)
Domestic honours (most recent triumph in brackets)
Spanish title: 1 (1946)
Spanish Cup: 5 (2010)
Ten-year European record (UEFA Cup/UEFA Europa League unless indicated otherwise)
2013/14: winners
2012/13: did not take part in UEFA club competition
2011/12: play-offs
2010/11: round of 32 (having transferred from UEFA Champions League play-offs)
2009/10: UEFA Champions League round of 16
2008/09: group stage
2007/08: UEFA Champions League round of 16
2006/07: winners
2005/06: winners
2004/05: round of 16
Records


";

                showText1.Text = @"UEFA club competition
• Biggest home win 
4-0 on four occasions, most recently v FC Karpaty Lviv
04/11/10, UEFA Europa League group stage
• Biggest away win 
1-6: FK Mladost Podgorica v Sevilla
09/08/13, UEFA Europa League third qualifying round second leg
0-5: WKS Śląsk Wrocław v Sevilla
29/08/13, UEFA Europa League play-off second leg
• Heaviest home defeat
0-2: Sevilla v Real Betis Balompié
13/03/14, UEFA Europa League round of 16 first leg
• Heaviest away defeat 
8-0: Real Madrid CF v Sevilla
23/01/58, European Champion Clubs' Cup quarter-finals first leg
UEFA Europa League/UEFA Cup
• Biggest home win
4-0 on three occasions, most recently v FC Karpaty Lviv (see above)
• Biggest away win 
1-6: FK Mladost Podgorica v Sevilla (see above)
0-5: WKS Śląsk Wrocław v Sevilla (see above)
• Heaviest home defeat
0-2: Sevilla v Real Betis Balompié (see above)
• Heaviest away defeat
4-0: 1. FC Kaiserslautern v Sevilla
08/12/82, third round second leg";



            }


            else if (teamCounter == 10)
            {
                showText.Text = @"1- Like Barça, they have won four European Cups: The first three came back-to-back in their golden era from 1974 to 1976, when the side was masterminded by Franz Beckenbauer (who is now their honorary president). They added the fourth in 2001.

2- They are the most successful team in German football history: They have won 23 leagues, 15 cups, and are also one of the few clubs to have won all of the European Cup, Cup Winners Cup and UEFA Cup.

3- They play at the Allianz Arena (called the München Arena in European competitions): In the north of the Bavarian capital its capacity is 68,000. It was opened in 2005 as one of the venues for the World Cup held the year after. It is admired around the world for its ultra-modern structure. 

4- The fastest champion: Bayern have won this season’s Bundesliga in all-time record time. They clinched the trophy with six games to spare.  

5- Jupp Heynckes the manager: The 67 year old German coach has been in charge since 2011. He’s travelled the football world and likes his teams to play the ball. His contract ends at the end of the season and is not being renewed.

6- Absentees: Striker Tony Kroos and defender Holger Badstuber are both currently sidelined through injury, and forward Mario Mandzukic will miss the first leg through suspension. But Bayern have a big squad with plenty of strength in depth.

7- Recent editions of the Champions League: Since winning the title in 2001, they have reached, but lost, two further finals in 2010 and 2012. In 2011, they went out in the round of 16 and in 2009 in the quarter finals.

8- Last meeting in 2009: In that season it was precisely Barça who put them out. Pep Guardiola’s stormed to a spectacular 4-0 win in the first leg, so a 1-1 draw in Munich was more than enough to ensure qualification.

9- July 24 friendly with Barça: The two teams will be meeting very shortly after this semi final in an already arranged summer charity match. It’s being called the Uli Hoeness Cup after Bayern’s current president, and will be played in the Allianz Arena.

10- Pep Guardiola the next manager: On January 16, Bayern Munich announced that they had signed the former Barcelona boss, who starts work in June 2013. The Catalan won 14 out of a possible 19 titles at FCB between 2008 and 2012, and has been taking a sabbatical this season.";
            }


            else if (teamCounter == 11)
            {
                showText.Text = @"1. The club's home colours are green and white. When the team first formed on September 12 1945, the coach had 10 green jerseys, and bed sheets donated by the public were sewn together by wives to make the shorts. 

2. Wolfsburg's first season in the Bundesliga was 1997/1998. On May 23 2009 they sealed their first ever Bundesliga title by beating Werder Bremen 5-1. 

3. Wolfsburg's manager is former VfB Stuttgart boss Armin Veh. He took over from Felix Magath in July, with Magath having agreed to join FC Schalke. 

4. Wolfsburg's star player is striker Edin Dzeko. The Bosnian attracted interest from a host of European big guns over the summer with Manchester City, Arsenal and AC Milan all mentioned. Sevilla are the latest club to be linked with a January move. He has scored 38 goals in 67 Bundesliga games. 

5. Former Newcastle striker Obafemi Martins made the switch to Wolfsburg in the summer. He has scored two goals in five appearances for his new team so far. United fans will remember Martins for his goal for the Magpies in last season's 1-1 draw at Old Trafford. 

6. The club's ground - opened for the 2003/2004 season - is the Volkswagen Arena which has a capacity of 30,000. There are 22,000 permanent seats and 4,000 temporary seats that can be converted to 8,000 standing places. 

7. Wolfsburg are sitting in sixth place in the Bundesliga table with four wins and three losses so far. They have scored 15 goals but conceded 14 in those fixtures. They beat CSKA Moscow 3-1 in their opening Champions League fixture thanks to a hat-trick from Brazilian forward Grafiti. 

8. Wolfsburg used to be managed by Wolfgang Wolf but he was sacked in 2003. Wolf's most recent job came at Greece Super League club Skoda Xanthi FC, but he left after just two and a half months in September this year.

9. Wolfsburg is located in Lower Saxony, towards the north of the country, and is home to the headquarters of car giant Volkswagen. Its population is a shade over 120,000. 

10. Wolfsburg reached the last 32 of the 2008/2009 UEFA Cup before being knocked out by Paris St Germain. It was only the second time the club had competed in the competition. ";
            }


            else if (teamCounter == 12)
            {
                showText.Text = @"BVB and Bayern face each other for the fifth time in 2013 following their meetings in the DFL Supercup, Champions League, Bundesliga and DFB Cup.
BVB are on a six-game unbeaten run against Bayern in the Bundesliga (four wins, two draws) - for the first time in club history.
BVB‘s last defeat to Bayern in the Bundesliga dates back to 13 February 2010 (a 3-1 loss at Bayern).
BVB have scored a goal against Bayern in each of their last 10 Bundesliga meetings – and in nine of them they also scored the opener.
Borussia have only lost one of their last seven home games against Bayern.
Bayern have not scored the opening goal in Dortmund since 2005.
Robert Lewandowski has yet to lose against Bayern in the Bundesliga (four wins, two draws) – in the 2012 DFB Cup final he also scored a hattrick against the Bavarian outfit.
Dante (three draws, three defeats) and Mandzukic (one draw, four defeats) have yet to win against Borussia Dortmund in the Bundesliga.
BVB have the best defensive record at home with just four goals conceded.
Bayern are on a 24-game unbeaten run on the road (20 wins, four draws) – their last defeat dates back to 11 April 2012, a 1-0 loss at BVB.";
            }


            else if (teamCounter == 13)
            {
                showText.Text = @"1. Bayer Leverkusen are the works team of Germany's largest chemical plant Bayer, the company who produce asprin.

2. A sports club was formed in 1904, hence the title Bayer 04 Leverkusen but a football team was not introduced until three years later.

3. Their local Rheinland rivals are two of Liverpool's old European adversaries FC Cologne and Borussia Moenchengladbach.

4. Leverkusen only won promotion to the top-flight of German football in 1979.

5. In 1988 they defeated Espanol to win the UEFA Cup, their first and so far only European trophy.

6. They have played in the Champions League quarter-final once before - in 1997/98 - but lost to Real Madrid

7. Their home stadium is the BayArena, which has a capacity of 25,050 (all-seated).

8. A fourth place finish in last seasons Bundesliga guaranteed them a place in this seasons Champions League.

9. They currently top the Bundesliga by a point from Borussia Dortmund and have scored more goals than anyone else in their division this season.

10. Liverpool defeated Leverkusen 3-2 in a pre-season friendly in Lustenau, Austria.";
            }




            else if (teamCounter == 15)
            {
                showText.Text = @"Full Name: Juventus Football Club

Founded In 1897

Nicknames: Bianconeri (Black and White), La Vecchia Signora (The Old Lady), La Goeba, La Fidanzata d’Italia (The Girlfriend of Italy), Zebre (zebras), Madama, La Signora Omicidi(The Lady Killer).

Juventus is the third oldest club in Italy after Genoa, Pro Patria and one of the oldest still active in the world.

The club was founded by Irish Students, who were in Turin at the time.

Juventus means young in Latin, it was named so because the creators were young students.

Their Chairman in the early 1900s, left the club to create FC Torino, Alfred Dick.

Once their chairman wanted to turn the clubs name into Jugen Fussverein. The club was about to seriously disappear.

Juventus weren’t anything special pre war but after the first war their squad was quite good..Edoardo Agnelli had bought the club in 1923 and had turn the clubs fortune’s around.

At first their uniform was pink and black with a tie but in 1905 they changed to the white and black of today.

Under Moggi, as director, Juventus signed Zidane, Davids, Thuram, Zlatan. They brought lots of superstars, making the team one of in the 90s and early 21st era.

Juventus being the club with most fans in Italy. And the most successful. It’s normal to have rivalries and Juve does have a few rivalries.

FC Torino are their direct rivals for being from the same city.  Their rivalry was at its peak in the 70s, in 76/77 when Juventus won the Scudetto with 51pts and Torino finishing in second with 50pts. In 2007 when they faced in the First division after a long time, violent clashes happened outside, 30 fans died.

The Rivalry with Inter Milan is an old one…Inter’s team was one of the best in the 60s and were winning titles like paper. Until Juventus  literally stole one, everyone thought Inter had won the league but they lost their last league game vs Mantova due to a mistake by Sarti their keeper at the time. Also the Calciopoli added injury to insult getting demoted in Serie B, their title was given away to Inter. And also Inter’s Vice President Marco Tronchetti Provera was the owner of Telecom the company that tapped the calls of Juventus Directors paying Referees.

Juventus have more Scudetto’s than anyone, 21.

Like all big historical clubs at some period they had magical players. Juventus legends include : Sivori was one of the most talented players in their 50s squad. He was famous for his big shaved head, arguing with referees and he won 3 titles in Serie A. Dino Zoff, a great goalkeeper of his time, one of the best actual, he went to Juve at the age of 30 and stayed their for 11 years. Also won the world cup at the age of 40. Michel Platini is another great player who played in Juventus, the manager called him a number 9 player and a half. Describing his playmaking abilities and his striker instincts. Roberto Baggio, he had injury problems when he was young, but managed to become one of Italy’s best strikers in the 90s. Pavel Nedved is another recent legend, having being a pivotal force in the Juves Champions League quest and scudetto reign in the early parts of the 21st century. Alessandro Del Piero, the captain, Juventus’s golden boy, the man he took over Vieri, Baggio in Italy.

Most appearances are held by Gaetano Scirea(552) but Del Piero will surpass him in a few games.

Most goals are held by Del Piero with 265 in all competitions.";
            }


            else if (teamCounter == 16)
            {
                showText.Text = @"AS Roma
Formed: 1927
Nickname: Giallorossi (Red and Yellows)

UEFA club competition honours (runners-up in brackets)
• European Champion Clubs' Cup: (1984)
• UEFA Cup: (1991)

Domestic honours (most recent triumph in brackets)
League title: 3 (2001)
Italian Cup: 9 (2008)

Ten-year European record (UEFA Champions League unless indicated otherwise)
2013/14: did not participate in UEFA competition
2012/13: did not participate in UEFA competition
2011/12: UEFA Europa League play-offs
2010/11: round of 16
2009/10: UEFA Europa League round of 32
2008/09: round of 16
2007/08: quarter-finals
2006/07: quarter-finals
2005/06: UEFA Cup round of 16
2004/05: group stage

Records
UEFA club competition
• Biggest home win 
7-0: Roma v ND Gorica 
28/09/00, UEFA Cup first round second leg 
7-0: Roma v Vitória FC 
16/09/99, UEFA Cup first round first leg

• Biggest away win 
1-7: KAA Gent v Roma
06/08/09, UEFA Europa League third qualifying round second leg

• Heaviest home defeat 
1-7: Roma v FC Bayern München
21/10/14, UEFA Champions League group stage

• Heaviest away defeat 
7-1: Manchester United FC v Roma
10/04/07, UEFA Champions League quarter-finals second leg

UEFA Champions League (group stage to final only) 
• Biggest home win 
5-1: Roma v PFC CSKA Moskva
17/09/14, group stage
4-0: Roma v FC Shakhtar Donetsk
12/09/2006, group stage

• Biggest away win
1-4: FC Dynamo Kyiv v Roma
27/11/2008, group stage
0-3: Valencia CF v AS Roma 
26/02/2003, second group stage

• Heaviest home defeat 
1-7: Roma v FC Bayern München (see above for details)

• Heaviest away defeat 
7-1: Manchester United FC v Roma (see above for details)AS Roma
Formed: 1927
Nickname: Giallorossi (Red and Yellows)

";

                showText1.Text = @"UEFA club competition honours (runners-up in brackets)
• European Champion Clubs' Cup: (1984)
• UEFA Cup: (1991)

Domestic honours (most recent triumph in brackets)
League title: 3 (2001)
Italian Cup: 9 (2008)

Ten-year European record (UEFA Champions League unless indicated otherwise)
2013/14: did not participate in UEFA competition
2012/13: did not participate in UEFA competition
2011/12: UEFA Europa League play-offs
2010/11: round of 16
2009/10: UEFA Europa League round of 32
2008/09: round of 16
2007/08: quarter-finals
2006/07: quarter-finals
2005/06: UEFA Cup round of 16
2004/05: group stage

Records
UEFA club competition
• Biggest home win 
7-0: Roma v ND Gorica 
28/09/00, UEFA Cup first round second leg 
7-0: Roma v Vitória FC 
16/09/99, UEFA Cup first round first leg

• Biggest away win 
1-7: KAA Gent v Roma
06/08/09, UEFA Europa League third qualifying round second leg

• Heaviest home defeat 
1-7: Roma v FC Bayern München
21/10/14, UEFA Champions League group stage

• Heaviest away defeat 
7-1: Manchester United FC v Roma
10/04/07, UEFA Champions League quarter-finals second leg

UEFA Champions League (group stage to final only) 
• Biggest home win 
5-1: Roma v PFC CSKA Moskva
17/09/14, group stage
4-0: Roma v FC Shakhtar Donetsk
12/09/2006, group stage

• Biggest away win
1-4: FC Dynamo Kyiv v Roma
27/11/2008, group stage
0-3: Valencia CF v AS Roma 
26/02/2003, second group stage

• Heaviest home defeat 
1-7: Roma v FC Bayern München (see above for details)

• Heaviest away defeat 
7-1: Manchester United FC v Roma (see above for details)";



            }


            else if (teamCounter == 17)
            {
                showText.Text = @"1.The club was founded as a football and cricket club on 16 December 1899 by English expatriates Alfred Edwards and Herbert Kilpin, who came from the English city of Nottingham.
2.The club has spent its entire history, with the exception of the 1980–81 and 1982–83 seasons, in the top flight of Italian football, known as Serie A since 1929–30.(80-81 season due to totonero scandal)
3.They are the most successful club in world football in terms of international trophies along with Boca Juniors, with 18 officially recognized UEFA and FIFA titles.";
            }





            else if (teamCounter == 18)
            {
                showText.Text = @"1. The Fiorentina was founded by Marquis Luigi Ridolfi in 1926 by uniting two different soccer teams: PGF Libertas Firenze and Club Sportivo Firenze.
 
2. Even though the Fiorentina was not established until 1926, soccer was introduced to Florence in 1898. The city's first team had an English name, the 'Florence Foot-Ball Club.'
 
3. The Fiorentina was the first Italian team to be in the finals of the Champions League, called at the time the Coppa dei Campioni d'Europa, in 1956-1957, but lost to Real Madrid 2-0.
 
4. The Fiorentina won the Serie A twice, the Coppa Italia six times, the Supercoppa Italiana once, and the UEFA Cup Winners' Cup, which was an annual competition between European cup winners from 1960-1999, once.
 
5. Midfielder Giancarlo Antognoni played almost his entire career (1972-1987) for the Fiorentina, and was the team captain for most of that time. He also played for the Italian national team from 1974 to 1983. The last two years of his professional career were played for Swiss team FC Lausanne-Sport.
 
6. The first Viola trainer was Hungarian ex-soccer player, Karl Csapkay.
 
7. Cesare Prandelli was the longest-serving coach for the Fiorentina and left the team to coach the Italian national team in 2010.
 
8. The Fiorentina has a twinning with only three other teams: Torino, Verona and Catanzaro. A twinning was desired, but never officially formed with the ‘Reds' from Liverpool, England in 2009 when the Fiorentina played them in the quarterfinals of the European Champions League.
 
9. The only Serie A team that does not have an official fan club in Florence is the Fiorentina's arch-rival, Juventus.
 
10. It may be true that the initial red and white jerseys were washed in the Arno river and turned purple, but the final decision to have the team's color be viola (purple) was made by Marquis Luigi Ridolfi. All the other professional sports teams in Florence such as water polo, rugby, basketball, and volleyball still today use red and white-the traditional colors of Florence-as their teams' colors.
 
11. There are 18 other international soccer teams that have purple as their team color. Among them are Toulouse (France), Real Valladolid (Spain), and Austria Vienna (Austria).
 
12. The Artemio Franchi stadium was built in 1931 in the shape of a ‘D' in honor of Il Duce, Benito Mussolini. It was first named after Giovanni Berta, a Florentine fascist martyr, but after World War II, the stadium changed its name to Stadio Comunale. A few years after Artemio Franchi's death, the stadium was renamed in honor of the team's ex-managing director who later became the president of the UEFA.
 
13. The section for visiting fans in the Artemio Franchi stadium is referred to as il formaggino by the locals because it looks like a wedge of cheese.
 
14. The Artemio Franchi stadium normally holds only 47,282 spectators, but the capacity was surpassed twice: in 1984 in a game against Inter (over 58,000) and in 1952 for a friendly match between Italy and England (over 84,000).";
            }


            else if (teamCounter == 19)
            {
                showText.Text = @"SSC Napoli
Formed: 1926
Nickname: Partenopei (a reference to Parthenope, one of the Sirens of Greek mythology)

UEFA club competition honours (runners-up in brackets)
• UEFA Cup (1): 1989

Domestic honours (most recent triumph in brackets)
League title: 2 (1990)
Italian Cup: 5 (2014)

Ten-year European record (UEFA Cup/UEFA Europa League unless indicated otherwise)
2013/14: round of 16 (having transferred from UEFA Champions League group stage)
2012/13: round of 32
2011/12: UEFA Champions League round of 16
2010/11: round of 32
2009/10: did not take part in UEFA club competition
2008/09: first round (having qualified as UEFA Intertoto Cup winners)
2007/08: did not take part in UEFA club competition
2006/07: did not take part in UEFA club competition
2005/06: did not take part in UEFA club competition
2004/05: did not take part in UEFA club competition

Records
UEFA club competition
• Biggest home win 
5-0: Napoli v KF Vllaznia
28/08/08, UEFA Cup second qualifying round second leg
• Biggest away win 
1-5: Valencia CF v Napoli
16/09/92, UEFA Cup first round first leg
0-4: Trabzonspor AŞ v Napoli
19/02/15, UEFA Europa League round of 32 first leg
• Heaviest home defeat 
0-3: Napoli v FC Viktoria Plzeň
14/02/13, UEFA Europa League round of 32 first leg
• Heaviest away defeat
5-1: SV Werder Bremen v Napoli
06/12/89, UEFA Cup third round second leg
UEFA Cup/UEFA Europa League
• Biggest home win
5-0: Napoli v KF Vllaznia (see above)
• Biggest away win
1-5: Valencia CF v Napoli (see above)
0-4: Trabzonspor AŞ v Napoli (see above)
• Heaviest home defeat
0-3: Napoli v FC Viktoria Plzeň (see above)
• Heaviest away defeat
5-1: SV Werder Bremen v Napoli (see above)

";
            }


            else if (teamCounter == 20)
            {
                showText.Text = @"Who of the following was the goalkeeper in 2004?
Jerome Alonzo. Jerome Alonzo was PSG's starting goalkeeper in the 03/04 season.

Who of the following did PSG acquire from AS Monaco for the 04/05 season?
Jerome Rothen. Jerome Rothen showed how talented he is by helping AS Monaco reach the UEFA Champions League finals.

Did PSG win the French first division championship between 1993-2003?
y. PSG's first championship was in the 1985-86 season. Their second was 1993-94.

What was the score in PSG's first game against Saint-Etienne in the 04/05 season?
2-2. PSG didn't win this game because of a goal in the 88' by Saint-Etienne forward Piquionne.

What is Lorik Cana's nationality?
Albanian. Lorik Cana was a defensive midfielder.

PSG acquired a player from Nantes FC for the 04/05 season.
True. Mario Yepes was that player.

Who of the following is Brazilian?
Reinaldo. Reinaldo had never started for Brazil in an official match.

Who of the following is a striker?
Pauleta. Pauleta played for Bordoeux FC for six years before joining PSG.

Which of the following was a goalkeeper?
Mohamed Benhamou. Benhamou was a young goalkeeper playing for PSG in 2004.

Luis Fernandez was PSG's coach for five years before being fired.
False. Luis Fernandez was PSG's coach for only two years before being fired in 2004.";
            }


            else if (teamCounter == 21)
            {
                showText.Text = @"Nicknames include : Les Gones, Lyon and OL.

Founded in 1899.

Their stadium is in Lyon and is called the Stade Gerland.

It was first apart of the Lyon Olympique Universitaire but then the association got split in two. 

In 1964, after they changed their association, they won their first title by defeating Bordeaux, 2-1, it was the Cup Of France.

It took 29 years for them to get relegated from ligue 1, in 1983, they stayed there till 1987.

Current Chair Jean Michel Aulas took over in 1987, he wanted to get European qualification in 5 years,  in 1989 they came back into the Ligue 1. After three years there they finished in the 5rd spot. Which was enough to get them into the Champions League of that year, 1993.

They got second place in the league in 1995 and several good games in the Uefa Cup. This lead to French company Pathe investing €15million in the club, taking control of 34% of it.

In 1999, Sonny Anderson was brought to the club, from Barcelona, The Brazilian helped the club win their first league title in 2002.

They had won that season by only a point but after that season they won each league season till 08/09 in which Bordeaux won the league, Lyon finishing 3rd, 9 points behind Bordeaux.

They have also been featured regularly in the Champions League, going as far as the quarter finals in 2001.

Their classical rivals are AS Saint Etienne, because in the 60s Etienne was one of the finest clubs in Europe and the world. The only club coming close to them was Real Madrid at the time. They dominated the French League and Europe..The club’s city are separated by only 50miles. When Etienne was winning titles Lyon was struggling and now Etienne is struggling and Lyon winning, though the rivalry has still been fierce as ever.

Lyon do have other rivals, like Marseille mainly because they were one of the teams to pressure Lyon during their reign in this decade, PSG, Bordeaux would be also considered rivals.";
            }


            else if (teamCounter == 22)
            {
                showText.Text = @"With Francesco Guidolin hired to replace Deschamps, one of Pastor's first tasks was to hold on to the players who had turned the club into one of the best in Europe. However, he failed to convince them to stay and their replacements were unable to replicate previous successes. Guidolin lasted only one year, before being replaced by assistant coach Laurent Banide who, in turn, only lasted a year, before being replaced by Brazilian Ricardo Gomes. In 2008, after four years at the club featuring six coaches and only mid-table finishes, Pastor left the club amid severe criticism of his management skills.

In 2008, Jérôme de Bontin, a leading shareholder of the club since 2003, took charge of the club, promising a complete shake-up. Under his reign as president, the club brought in players such as Park Chu-Young and Freddy Adu, so they did not find much success on the pitch, going through a torrid season and only managing a mid-table finish. De Bontin resigned at the end of the season, replaced by banker Etienne Franzi and a new board of directors.

In July 2009, Ricardo Gomes was replaced by former Cannes and Rennes coach Guy Lacombe, inheriting a youthful squad featuring numerous highly lauded youth team prospects, including Cédric Mongongu, Serge Gakpé, Vincent Muratori, Frédéric Nimani, Nicolas N'Koulou, Park Chu-Young, Yohan Mollo, and Yohann Thuram-Ulien. Lacombe led Monaco to 8th place in Ligue 1 in his first season in charge, but he was unable to replicate this performance in his second season, and was sacked in January 2011, with Monaco in 17th place in Ligue 1. He was replaced by former coach Laurent Banide, who was unable to turn around the club's fortunes; Monaco finished the 2010–11 season in 18th position, thus becoming relegated to Ligue 2.

In December 2011, 66.67% of the club was sold to the Russian billionaire Dmitry Rybolovlev while the club were bottom of Ligue 2. Banide was sacked due to this poor start to the 2011–12 season, and was replaced by Italian manager Marco Simone. Although he lifted the club to 8th by the end of the season, the club's board targeted promotion for the upcoming season and so fired him and appointed his compatriot Claudio Ranieri, whose attacking style of football saw the club score 64 goals in the 2012–13 season. With the club only losing four times, Monaco finished the season as champions. Using Rybolovlev's funds, Monaco were one of the biggest spenders in Europe in 2013, spending roughly £140 million, including a club record £50 million for Radamel Falcao from Atletico Madrid.";
            }


            else if (teamCounter == 23)
            {
                showText.Text = @"•	It was founded in 1892 by Rene Dufaure but it was officially known as Olympique De Marseille only in 1899.
•	They have won 8 league titles and 10 Coup De France.
•	Their greatest achievement is winning the Champions League in 1993.
•	But they have been a shadow of their former self. For a decade they haven’t won anything. Their best season in a long while was 08/09 where they finished 2nd place over rivals Lyon and also qualified for the Champions League.
•	They won their first professional title in 1937 in their current stadium Le Velodrome..
•	In the 80s to the early 90s they had one of the best squads in Europe, they had players like Jean Pierre Papin, Didier Deschamp, Rudi Voller, Eric Cantona.
•	In 1999, they added the gold color in their jerseys for their 100th anniversary and still have it to this day.
•	They have been in two in UEFA Cup Finals, they are the only French team to win the Champions League.
•	The Club’s motto is Droit Au But, which translates into Right To Score/ Goal.
•	Roger Scotti holds the record for the most appearances, 402.
•	Most g0als are held by the Swed, Gunnar Andersson, 187 goals.
•	Jean Pierre Papin has only 3 goals less than Gunnar.
•	Their home game song is Jump by Van Halen, it’s played before every home game.
•	Their goal song is Puff Dady’s Come With Me.
•	They have many other amazing records like, allowing the least goals in a season, which was 21 in the season of 91/92.
•	They also hold the record for most away wins with OL and AS Etienne, which is 12, in 72/73.
•	They also have the best top scorer in ligue 1 ever, who had 44 goals in one season, in the season of 71/72.
•	In their stadium, The Velodrome, they have 3 sections, 1 for casual fans, 1 for ultras and 1 for the relations with other clubs, the sections called AEK-Livorno.
•	Their main rivals are PSG, who are in the biggest city of France, Paris and Marseille being the other big city club. PSG and Marseille would duke it would before Lyon took the dominance in the France. They are pretty close to each other. PSG has a stadium capacity of 40k in their Parc Des Princes. Marseille have the biggest stadium in France, with a capacity of 60k, The Velodrome. Whenever these two meet about 3000 cops are to present in the grounds around the arena.

";
            }


        }




    }
}