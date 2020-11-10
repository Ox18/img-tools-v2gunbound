StageNum		= 9
MapProp			= 15				
GameMode		= 1

function GameOption(pGameData)
	pGameData:MaxMan( 1 )
	pGameData:Time( 4 )	
	pGameData:MapImpact( 1 )
	pGameData:Damage( 1 )
	pGameData:Moblie( 0 )
	pGameData:ItemSupport1( 1, 3 )
	pGameData:ItemSupport2( 0, 0 )	
	pGameData:ItemSlot1( 1, 0, 0, 0, 0, 0, 0 )
	pGameData:SuddenOption( 1, 3, 1 )
	pGameData:Wind( 0, 0, 0 )	
	pGameData:Dummy(  500, 13, 38, "KrizAndSaint", 1 )
	pGameData:Dummy(  700, -1, 35, "l3oyWonder", 1 )
	pGameData:Dummy(  900, -1, 33, "pisilo", 1 )
	pGameData:Dummy( 1000, -1, 33, "SinVidaxP", 1 )
	pGameData:Dummy( 1150, 0, 33, "xXReyFeNixD", 1 )
	return 0
end

function MainMission(pGameData)
	pGameData:MainMissionType( 21, 4 )
end

MoonState			= 0
Moon_1				= 3
Moon_2				= 3
Moon_3				= 3
Moon_4				= 3
Moon_5				= 3
Moon_6				= 3
Moon_7				= 3
Moon_8				= 3

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


StageName		= "2da supresion"

MissionText_1		= "Condición de la misión"
MissionText_2		= "Destruir 3 moviles!"
MissionText_3		= "[Record actual]"
MissionText_4		= "Completada: %d/3 Moviles"
MissionText_5		= ""
MissionText_6		= ""

BonusText		= "%s   [Bono completo] +%dGold, +%dGP"

Story			= "Después que los disturbios fueron mitigados, otros disturbios aparecen. Estas mitigando disturbios otra vez sin saber ninguna razón."
Mapinfo_1		= "Misión: Destruir 4 moviles"
Mapinfo_2		= "Tiempo: 4 minutos"
Mapinfo_3		= "Móvil: Cualquier Movil"
Mapinfo_4		= "Item: Cualquier item"
Mapinfo_5		= "Mapa: Nirvane(Lado B)"
Mapinfo_6		= "Jugador: 1 Jugador"
Mapinfo_7		= "Premio: 12GP"
Mapinfo_8		= "Reintentar premio: 12GP, 300Gold"
Mapinfo_9		= "Entregamos los 50 puntos"

ResultText_1	= "Terminado : %d * %d = %d"
ResultText_2	= "Bonificación : %d * %d = %d"
ResultText_3	= "Tiempo    : %d * %d / %d = %d"
ResultText_4	= "Energia : %d * %d = %d"
ResultText_5	= "Daño : %d * %d = %d"
ResultText_6	= "Turno : %d * %d = %d"
ResultText_7	= "Puntaje total : %d"
ResultText_8	= "Mi mejor record : %d"
