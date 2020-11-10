StageNum		= 10
MapProp			= 6				
GameMode		= 1

function GameOption(pGameData)
	pGameData:MaxMan( 1 )
	pGameData:Time( 4 )	
	pGameData:MapImpact( 1 )
	pGameData:Damage( 1 )
	pGameData:Moblie( 0 )
	pGameData:ItemSupport1( 1, 99 )
	pGameData:ItemSupport2( 0, 0 )	
	pGameData:ItemSlot1( 1, 0, 0, 0, 0, 0, 0 )
	pGameData:SuddenOption( 1, 2, 1 )
	pGameData:Wind( 0, 0, 0 )	
	pGameData:Dummy(  400, 4, 0, "VenusDeMilo", 1 )
	pGameData:Dummy(  600, 13, 0, "SolYluna", 1 )
	pGameData:Dummy(  700, -1, 0, "Observador", 1 )
	pGameData:Dummy(  800, -1,  0, "Nyxbuck", 1 )
	pGameData:Dummy(  900, -1, 0, "SolYluna", 1 )
	pGameData:Dummy( 1200, 13, 0, "NyxHero", 1 )
	pGameData:Dummy( 1400, 4, 0, "KoreaGunba", 1 )
	return 0
end

function MainMission(pGameData)
	pGameData:MainMissionType( 21, 7 )
end

MoonState			= 1
Moon_1				= 0
Moon_2				= 5
Moon_3				= 2
Moon_4				= 3
Moon_5				= 4
Moon_6				= 0
Moon_7				= 2
Moon_8				= 4

MoonPosState	= 0
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
PTMinPos_5		= 0;	PTMinPos_6		= 0;	PTMinPos_7		= 0;	PTMinPos_8		= 0;
PTMaxPos_5		= 0;	PTMaxPos_6		= 0;	PTMaxPos_7		= 0;	PTMaxPos_8		= 0;
BlackMinPos_5	= 0;	BlackMinPos_6	= 0;	BlackMinPos_7	= 0;	BlackMinPos_8	= 0;
BlackMaxPos_5	= 0;	BlackMaxPos_6	= 0;	BlackMaxPos_7	= 0;	BlackMaxPos_8	= 0;
MirrorMinPos_5	= 0;	MirrorMinPos_6	= 0;	MirrorMinPos_7	= 0;	MirrorMinPos_8	= 0;
MirrorMaxPos_5	= 0;	MirrorMaxPos_6	= 0;	MirrorMaxPos_7	= 0;	MirrorMaxPos_8	= 0;


StageName		= "Revolucion"

MissionText_1		= "Condición de la misión"
MissionText_2		= "Hacer frente a los GMs"
MissionText_3		= "[Record actual]"
MissionText_4		= "Completada: %d/7 Moviles"
MissionText_5		= ""
MissionText_6		= ""

BonusText		= "%s   [Bono completo] +%dGold, +%dGP"

Story			= "El disturbio Hu Boee fue causado por la extorsión de un GM. Te molestas y decides ayudar a los que causan el disturbio para castigar a los GM que estan a cargo. Castiga a los 7 GM que estan a cargo!"
Mapinfo_1		= "Misión: Hacer frente a los GMs"
Mapinfo_2		= "Tiempo: 4 minutos"
Mapinfo_3		= "Móvil: Cualquier Movil"
Mapinfo_4		= "Item: Dual sin limite"
Mapinfo_5		= "Mapa: Dragon(Lado A)"
Mapinfo_6		= "Jugador: 1 Jugador"
Mapinfo_7		= "Premio: 10GP"
Mapinfo_8		= "Reintentar premio: 5GP, 100Gold"
Mapinfo_9		= ""

ResultText_1	= "Terminado : %d * %d = %d"
ResultText_2	= "Bonificación : %d * %d = %d"
ResultText_3	= "Tiempo    : %d * %d / %d = %d"
ResultText_4	= "Energia : %d * %d = %d"
ResultText_5	= "Daño : %d * %d = %d"
ResultText_6	= "Turno : %d * %d = %d"
ResultText_7	= "Puntaje total : %d"
ResultText_8	= "Mi mejor record : %d"
