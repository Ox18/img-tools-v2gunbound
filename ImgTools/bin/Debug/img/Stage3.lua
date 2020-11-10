StageNum		= 3
MapProp			= 3				
GameMode		= 1

function GameOption(pGameData)
	pGameData:MaxMan( 1 )
	pGameData:Time( 3 )	
	pGameData:MapImpact( 0 )
	pGameData:Damage( 0 )
	pGameData:Moblie( 6 )		
	pGameData:ItemSupport1( 0, 0 )
	pGameData:ItemSupport2( 10, 3 )	
	pGameData:ItemSlot1( 1, 0, 0, 0, 0, 0, 0 )
	pGameData:SuddenOption( 1, 2, 1 )
	pGameData:Wind( 0, 0, 0 )
	pGameData:Dummy( 900, -1, 35, "Anti boomer", 1 )
	pGameData:Dummy( 1200, -1, 35, "llPattyNet", 1 )
	return 0
end

function MainMission(pGameData)
	pGameData:MainMissionType( 10, 5 )
end

MoonState			= 2
Moon_1				= 3
Moon_2				= 3
Moon_3				= 3
Moon_4				= 3
Moon_5				= 3
Moon_6				= 3
Moon_7				= 3
Moon_8				= 3

MoonPosState	= 1
TornadoMinPos_1	= 0;	TornadoMinPos_2	= 0;	TornadoMinPos_3	= 0;	TornadoMinPos_4	= 0;
TornadoMaxPos_1	= 0;	TornadoMaxPos_2	= 0;	TornadoMaxPos_3	= 0;	TornadoMaxPos_4	= 0;
PowerMinPos_1	= 0;	PowerMinPos_2	= 0;	PowerMinPos_3	= 0;	PowerMinPos_4	= 0;
PowerMaxPos_1	= 0;	PowerMaxPos_2	= 0;	PowerMaxPos_3	= 0;	PowerMaxPos_4	= 0;
PTMinPos_1		= 0;	PTMinPos_2		= 0;	PTMinPos_3		= 0;	PTMinPos_4		= 0;
PTMaxPos_1		= 0;	PTMaxPos_2		= 0;	PTMaxPos_3		= 0;	PTMaxPos_4		= 0;
BlackMinPos_1	= 0;	BlackMinPos_2	= 0;	BlackMinPos_3	= 0;	BlackMinPos_4	= 0;
BlackMaxPos_1	= 0;	BlackMaxPos_2	= 0;	BlackMaxPos_3	= 0;	BlackMaxPos_4	= 0;
MirrorMinPos_1	= 300;	MirrorMinPos_2	= 300;	MirrorMinPos_3	= 300;	MirrorMinPos_4	= 300;
MirrorMaxPos_1	= 400;	MirrorMaxPos_2	= 400;	MirrorMaxPos_3	= 400;	MirrorMaxPos_4	= 400;

TornadoMinPos_5	= 0;	TornadoMinPos_6	= 0;	TornadoMinPos_7	= 0;	TornadoMinPos_8	= 0;
TornadoMaxPos_5	= 0;	TornadoMaxPos_6	= 0;	TornadoMaxPos_7	= 0;	TornadoMaxPos_8	= 0;
PowerMinPos_5	= 0;	PowerMinPos_6	= 0;	PowerMinPos_7	= 0;	PowerMinPos_8	= 0;
PowerMaxPos_5	= 0;	PowerMaxPos_6	= 0;	PowerMaxPos_7	= 0;	PowerMaxPos_8	= 0;
PTMinPos_5		= 0;	PTMinPos_6		= 0;	PTMinPos_7	= 0;		PTMinPos_8		= 0;
PTMaxPos_5		= 0;	PTMaxPos_6		= 0;	PTMaxPos_7	= 0;		PTMaxPos_8		= 0;
BlackMinPos_5	= 0;	BlackMinPos_6	= 0;	BlackMinPos_7	= 0;	BlackMinPos_8	= 0;
BlackMaxPos_5	= 0;	BlackMaxPos_6	= 0;	BlackMaxPos_7	= 0;	BlackMaxPos_8	= 0;
MirrorMinPos_5	= 300;	MirrorMinPos_6	= 300;	MirrorMinPos_7	= 300;	MirrorMinPos_8	= 300;
MirrorMaxPos_5	= 400;	MirrorMaxPos_6	= 400;	MirrorMaxPos_7	= 400;	MirrorMaxPos_8	= 400;


StageName		= "Festival Miramo"

MissionText_1		= "Condición de la misión"
MissionText_2		= "5 Tiros Boomer"
MissionText_3		= "[Record actual]"
MissionText_4		= "Completada : %d / 5veces"
MissionText_5		= ""
MissionText_6		= ""

BonusText		= "%s   [Bono completo] +%dGold, +%dGP"

Story			= "El festival Miramo es hoy. Obtén regalos probando tu valentía con el móvil Boomer. Es gratis unirte al evento. Entra al evento y obtén premios."
Mapinfo_1		= "Misión: 5 Tiros Boomer"
Mapinfo_2		= "Tiempo: 3 minutos"
Mapinfo_3		= "Móvil: Bommer"
Mapinfo_4		= "Item: Radar Skill (3)"
Mapinfo_5		= "Mapa: Metropolis(Lado A)"
Mapinfo_6		= "Jugador: 1 Jugador"
Mapinfo_7		= "Premio: 4GP"
Mapinfo_8		= "Reintentar premio: 2GP, 100Gold"
Mapinfo_9		= ""

ResultText_1	= "Terminado : %d * %d = %d"
ResultText_2	= "Bonificación : %d * %d = %d" 
ResultText_3	= "Tiempo    : %d * %d / %d = %d"
ResultText_4	= "Energia : %d * %d = %d"
ResultText_5	= "Daño : %d * %d = %d"
ResultText_6	= "Turno : %d * %d = %d"
ResultText_7	= "Puntaje total : %d"
ResultText_8	= "Mi mejor record : %d"
