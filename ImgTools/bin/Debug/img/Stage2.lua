StageNum		= 2
MapProp			= 2				
GameMode		= 1

function GameOption(pGameData)
	pGameData:MaxMan( 1 )
	pGameData:Time( 2 )	
	pGameData:MapImpact( 1 )
	pGameData:Damage( 0 )
	pGameData:Moblie( 0 )		
	pGameData:ItemSupport1( 1, 99 )
	pGameData:ItemSupport2( 0, 0 )	
	pGameData:ItemSlot1( 1, 0, 0, 0, 0, 0, 0 )
	pGameData:SuddenOption( 1, 2, 1 )
	pGameData:Wind( 0, 0, 0 )
	pGameData:Dummy( 500, 0, 30, "Knockout", 0 )
	pGameData:Dummy( 1100, 0, 30, "KenYiHimurA", 1 )			
	return 0
end

function MainMission(pGameData)
	pGameData:MainMissionType( 14, 5 )
end

MoonState			= 1
Moon_1				= 7
Moon_2				= 8
Moon_3				= 7
Moon_4				= 7
Moon_5				= 3
Moon_6				= 7
Moon_7				= 7
Moon_8				= 1

MoonPosState	= 1
TornadoMinPos_1	= 0;	TornadoMinPos_2	= 0;	TornadoMinPos_3	= 0;	TornadoMinPos_4	= 0;
TornadoMaxPos_1	= 0;	TornadoMaxPos_2	= 0;	TornadoMaxPos_3	= 0;	TornadoMaxPos_4	= 0;
PowerMinPos_1	= 0;	PowerMinPos_2	= 0;	PowerMinPos_3	= 0;	PowerMinPos_4	= 0;
PowerMaxPos_1	= 0;	PowerMaxPos_2	= 0;	PowerMaxPos_3	= 0;	PowerMaxPos_4	= 0;
PTMinPos_1		= 0;	PTMinPos_2		= 0;	PTMinPos_3		= 0;	PTMinPos_4		= 0;
PTMaxPos_1		= 0;	PTMaxPos_2		= 0;	PTMaxPos_3		= 0;	PTMaxPos_4		= 0;
BlackMinPos_1	= 0;	BlackMinPos_2	= 0;	BlackMinPos_3	= 0;	BlackMinPos_4	= 0;
BlackMaxPos_1	= 0;	BlackMaxPos_2	= 0;	BlackMaxPos_3	= 0;	BlackMaxPos_4	= 0;
MirrorMinPos_1	= 0;	MirrorMinPos_2	= 0;	MirrorMinPos_3	= 0;	MirrorMinPos_4	= 0;
MirrorMaxPos_1	= 0;	MirrorMaxPos_2	= 0;	MirrorMaxPos_3	= 0;	MirrorMaxPos_4	= 0;

TornadoMinPos_5	= 0;	TornadoMinPos_6	= 0;	TornadoMinPos_7	= 0;	TornadoMinPos_8	= 0;
TornadoMaxPos_5	= 0;	TornadoMaxPos_6	= 0;	TornadoMaxPos_7	= 0;	TornadoMaxPos_8	= 0;
PowerMinPos_5	= 0;	PowerMinPos_6	= 0;	PowerMinPos_7	= 0;	PowerMinPos_8	= 0;
PowerMaxPos_5	= 0;	PowerMaxPos_6	= 0;	PowerMaxPos_7	= 0;	PowerMaxPos_8	= 0;
PTMinPos_5		= 0;	PTMinPos_6		= 0;	PTMinPos_7	= 0;		PTMinPos_8		= 0;
PTMaxPos_5		= 0;	PTMaxPos_6		= 0;	PTMaxPos_7	= 0;		PTMaxPos_8		= 0;
BlackMinPos_5	= 0;	BlackMinPos_6	= 0;	BlackMinPos_7	= 0;	BlackMinPos_8	= 0;
BlackMaxPos_5	= 0;	BlackMaxPos_6	= 0;	BlackMaxPos_7	= 0;	BlackMaxPos_8	= 0;
MirrorMinPos_5	= 0;	MirrorMinPos_6	= 0;	MirrorMinPos_7	= 0;	MirrorMinPos_8	= 0;
MirrorMaxPos_5	= 0;	MirrorMaxPos_6	= 0;	MirrorMaxPos_7	= 0;	MirrorMaxPos_8	= 0;


StageName		= "Destructivo"

MissionText_1		= "Condición de la misión"
MissionText_2		= "5 Tiros excelentes"
MissionText_3		= "[Record actual]"
MissionText_4		= "Completada: %d /5veces"
MissionText_5		= ""
MissionText_6		= ""

BonusText		= "%s   [Bono completo] +%dGold, +%dGP"

Story			= "Hu Boee desarrollo una pólvora de alto nivel explosivo. Ellos hicieron una petición para publicitar y probar para ver si puede demostrar su poder. Haz tu mejor esfuerzo para demostrar su gran poder."
Mapinfo_1		= "Misión: 5 Tiros excelentes"
Mapinfo_2		= "Tiempo: 2 minutos"
Mapinfo_3		= "Móvil: Cualquier Movil"
Mapinfo_4		= "Item: Dual sin limite"
Mapinfo_5		= "Mapa: Nirvane(Lado A)"
Mapinfo_6		= "Jugador: 1 Jugador"
Mapinfo_7		= "Premio: 3GP"
Mapinfo_8		= "Reintentar premio: 3GP, 100Gold"
Mapinfo_9		= "Entregamos los 50 puntos"

ResultText_1	= "Terminado : %d * %d = %d"
ResultText_2	= "Bonificación : %d * %d = %d"
ResultText_3	= "Tiempo    : %d * %d / %d = %d"
ResultText_4	= "Energia : %d * %d = %d"
ResultText_5	= "Daño : %d * %d = %d"
ResultText_6	= "Turno : %d * %d = %d"
ResultText_7	= "Puntaje total : %d"
ResultText_8	= "Mi mejor record : %d"
