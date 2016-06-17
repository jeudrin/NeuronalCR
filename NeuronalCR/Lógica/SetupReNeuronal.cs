using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronalCR.Lógica;
using NeuronalCR.Class;

namespace NeuronalCR.Lógica
{
    /// <summary>
    /// Clase que hace setup a los patrones de la red y a la red misma
    /// </summary>
    class SetupReNeuronal
    {
        /// <summary>
        /// crea la red neuronal
        /// </summary>
        /// <param name="backpropagation">instancia de la clase de backpropagation</param>
        public void createNeuralNetwork(Backpropagation backpropagation)
        {
            // Tabla de Neuronas de la red neuronal
            // 6 neuronas de inicio.
            Neurona i1 = new Neurona("i1");
            Neurona i2 = new Neurona("i2");
            Neurona i3 = new Neurona("i3");
            Neurona i4 = new Neurona("i4");
            Neurona i5 = new Neurona("i5");
            Neurona i6 = new Neurona("i6");
            Neurona i7 = new Neurona("i7");
            Neurona i8 = new Neurona("i8");
            Neurona i9 = new Neurona("i9");
            Neurona i10 = new Neurona("i10");
            Neurona i11 = new Neurona("i11");
            Neurona i12 = new Neurona("i12");
            Neurona i13 = new Neurona("i13");
            Neurona i14 = new Neurona("i14");
            Neurona i15 = new Neurona("i15");
            Neurona i16 = new Neurona("i16");
            Neurona i17 = new Neurona("i17");
            Neurona i18 = new Neurona("i18");
            Neurona i19 = new Neurona("i19");
            Neurona i20 = new Neurona("i20");
            Neurona i21 = new Neurona("i21");
            Neurona i22 = new Neurona("i22");
            Neurona i23 = new Neurona("i23");
            Neurona i24 = new Neurona("i24");
            Neurona i25 = new Neurona("i25");
            Neurona i26 = new Neurona("i26");
            Neurona i27 = new Neurona("i27");
            Neurona i28 = new Neurona("i28");
            Neurona i29 = new Neurona("i29");
            Neurona i30 = new Neurona("i30");
            Neurona i31 = new Neurona("i31");
            Neurona i32 = new Neurona("i32");
            Neurona i33 = new Neurona("i33");
            Neurona i34 = new Neurona("i34");
            Neurona i35 = new Neurona("i35");
            Neurona i36 = new Neurona("i36");

            // 8 neuronas de capa oculta.
            Neurona h1 = new Neurona("h1");
            Neurona h2 = new Neurona("h2");
            Neurona h3 = new Neurona("h3");
            Neurona h4 = new Neurona("h4");
            Neurona h5 = new Neurona("h5");
            Neurona h6 = new Neurona("h6");
            Neurona h7 = new Neurona("h7");
            Neurona h8 = new Neurona("h8");

            // 6 neuronas de capa de salida.
            Neurona o1 = new Neurona("o1");
            Neurona o2 = new Neurona("o2");
            Neurona o3 = new Neurona("o3");
            Neurona o4 = new Neurona("o4");
            Neurona o5 = new Neurona("o5");
            Neurona o6 = new Neurona("o6");

            //Ahora procedemos a crear las aristas que conectan las neuronas.
            NeuronaConPeso arista1 = new NeuronaConPeso();
            arista1.neurona = i1;
            arista1.peso = 0.1;

            NeuronaConPeso arista2 = new NeuronaConPeso();
            arista2.neurona = i1;
            arista2.peso = 0.5;

            NeuronaConPeso arista3 = new NeuronaConPeso();
            arista3.neurona = i1;
            arista3.peso = -0.4;

            NeuronaConPeso arista4 = new NeuronaConPeso();
            arista4.neurona = i1;
            arista4.peso = 0.3;

            NeuronaConPeso arista5 = new NeuronaConPeso();
            arista5.neurona = i1;
            arista5.peso = 0.2;

            NeuronaConPeso arista6 = new NeuronaConPeso();
            arista6.neurona = i1;
            arista6.peso = 0.4;

            NeuronaConPeso arista7 = new NeuronaConPeso();
            arista7.neurona = i2;
            arista7.peso = -0.1;

            NeuronaConPeso arista8 = new NeuronaConPeso();
            arista8.neurona = i2;
            arista8.peso = -0.2;

            NeuronaConPeso arista9 = new NeuronaConPeso();
            arista9.neurona = i2;
            arista9.peso = 0.3;

            NeuronaConPeso arista10 = new NeuronaConPeso();
            arista10.neurona = i2;
            arista10.peso = -0.3;

            NeuronaConPeso arista11 = new NeuronaConPeso();
            arista11.neurona = i2;
            arista11.peso = -0.5;

            NeuronaConPeso arista12 = new NeuronaConPeso();
            arista12.neurona = i2;
            arista12.peso = 0.5;

            NeuronaConPeso arista13 = new NeuronaConPeso();
            arista13.neurona = i3;
            arista13.peso = -0.2;

            NeuronaConPeso arista14 = new NeuronaConPeso();
            arista14.neurona = i3;
            arista14.peso = 0.15;

            NeuronaConPeso arista15 = new NeuronaConPeso();
            arista15.neurona = i3;
            arista15.peso = -0.073;

            NeuronaConPeso arista16 = new NeuronaConPeso();
            arista16.neurona = i3;
            arista16.peso = -0.423;

            NeuronaConPeso arista17 = new NeuronaConPeso();
            arista17.neurona = i3;
            arista17.peso = 0.102;

            NeuronaConPeso arista18 = new NeuronaConPeso();
            arista18.neurona = i3;
            arista18.peso = 0.32;

            NeuronaConPeso arista19 = new NeuronaConPeso();
            arista19.neurona = i4;
            arista19.peso = -0.234;

            NeuronaConPeso arista20 = new NeuronaConPeso();
            arista20.neurona = i4;
            arista20.peso = 0.378;

            NeuronaConPeso arista21 = new NeuronaConPeso();
            arista21.neurona = i4;
            arista21.peso = 0.293;

            NeuronaConPeso arista22 = new NeuronaConPeso();
            arista22.neurona = i4;
            arista22.peso = -0.5;

            NeuronaConPeso arista23 = new NeuronaConPeso();
            arista23.neurona = i4;
            arista23.peso = 0.492;

            NeuronaConPeso arista24 = new NeuronaConPeso();
            arista24.neurona = i4;
            arista24.peso = 0.312;

            NeuronaConPeso arista25 = new NeuronaConPeso();
            arista25.neurona = i5;
            arista25.peso = -0.341;

            NeuronaConPeso arista26 = new NeuronaConPeso();
            arista26.neurona = i5;
            arista26.peso = 0.133;

            NeuronaConPeso arista27 = new NeuronaConPeso();
            arista27.neurona = i5;
            arista27.peso = 0.258;

            NeuronaConPeso arista28 = new NeuronaConPeso();
            arista28.neurona = i5;
            arista28.peso = -0.4101;

            NeuronaConPeso arista29 = new NeuronaConPeso();
            arista29.neurona = i5;
            arista29.peso = 0.381;

            NeuronaConPeso arista30 = new NeuronaConPeso();
            arista30.neurona = i5;
            arista30.peso = 0.2;

            NeuronaConPeso arista31 = new NeuronaConPeso();
            arista31.neurona = i6;
            arista31.peso = -0.194;

            NeuronaConPeso arista32 = new NeuronaConPeso();
            arista32.neurona = i6;
            arista32.peso = 0.349;

            NeuronaConPeso arista33 = new NeuronaConPeso();
            arista33.neurona = i6;
            arista33.peso = -0.402;

            NeuronaConPeso arista34 = new NeuronaConPeso();
            arista34.neurona = i6;
            arista34.peso = 0.5;

            NeuronaConPeso arista35 = new NeuronaConPeso();
            arista35.neurona = i6;
            arista35.peso = -0.234;

            NeuronaConPeso arista36 = new NeuronaConPeso();
            arista36.neurona = i6;
            arista36.peso = -0.111;

            NeuronaConPeso arista37 = new NeuronaConPeso();
            arista37.neurona = h1;
            arista37.peso = -0.162;

            NeuronaConPeso arista38 = new NeuronaConPeso();
            arista38.neurona = h1;
            arista38.peso = 0.378;

            NeuronaConPeso arista39 = new NeuronaConPeso();
            arista39.neurona = h1;
            arista39.peso = 0.272;

            NeuronaConPeso arista40 = new NeuronaConPeso();
            arista40.neurona = h1;
            arista40.peso = 0.462;

            NeuronaConPeso arista41 = new NeuronaConPeso();
            arista41.neurona = h1;
            arista41.peso = -0.249;

            NeuronaConPeso arista42 = new NeuronaConPeso();
            arista42.neurona = h1;
            arista42.peso = 0.157;

            NeuronaConPeso arista43 = new NeuronaConPeso();
            arista43.neurona = h2;
            arista43.peso = 0.262;

            NeuronaConPeso arista44 = new NeuronaConPeso();
            arista44.neurona = h2;
            arista44.peso = -0.414;

            NeuronaConPeso arista45 = new NeuronaConPeso();
            arista45.neurona = h2;
            arista45.peso = 0.397;

            NeuronaConPeso arista46 = new NeuronaConPeso();
            arista46.neurona = h2;
            arista46.peso = -0.137;

            NeuronaConPeso arista47 = new NeuronaConPeso();
            arista47.neurona = h2;
            arista47.peso = 0.198;

            NeuronaConPeso arista48 = new NeuronaConPeso();
            arista48.neurona = h2;
            arista48.peso = -0.321;

            NeuronaConPeso arista49 = new NeuronaConPeso();
            arista49.neurona = h3;
            arista49.peso = 0.272;

            NeuronaConPeso arista50 = new NeuronaConPeso();
            arista50.neurona = h3;
            arista50.peso = -0.346;

            NeuronaConPeso arista51 = new NeuronaConPeso();
            arista51.neurona = h3;
            arista51.peso = 0.421;

            NeuronaConPeso arista52 = new NeuronaConPeso();
            arista52.neurona = h3;
            arista52.peso = -0.179;

            NeuronaConPeso arista53 = new NeuronaConPeso();
            arista53.neurona = h3;
            arista53.peso = -0.5;

            NeuronaConPeso arista54 = new NeuronaConPeso();
            arista54.neurona = h3;
            arista54.peso = 0.449;

            NeuronaConPeso arista55 = new NeuronaConPeso();
            arista55.neurona = h4;
            arista55.peso = 0.219;

            NeuronaConPeso arista56 = new NeuronaConPeso();
            arista56.neurona = h4;
            arista56.peso = 0.371;

            NeuronaConPeso arista57 = new NeuronaConPeso();
            arista57.neurona = h4;
            arista57.peso = -0.185;

            NeuronaConPeso arista58 = new NeuronaConPeso();
            arista58.neurona = h4;
            arista58.peso = -0.447;

            NeuronaConPeso arista59 = new NeuronaConPeso();
            arista59.neurona = h4;
            arista59.peso = 0.089;

            NeuronaConPeso arista60 = new NeuronaConPeso();
            arista60.neurona = h4;
            arista60.peso = -0.1666;

            NeuronaConPeso arista61 = new NeuronaConPeso();
            arista61.neurona = h5;
            arista61.peso = 0.453;

            NeuronaConPeso arista62 = new NeuronaConPeso();
            arista62.neurona = h5;
            arista62.peso = 0.3042;

            NeuronaConPeso arista63 = new NeuronaConPeso();
            arista63.neurona = h5;
            arista63.peso = -0.184;

            NeuronaConPeso arista64 = new NeuronaConPeso();
            arista64.neurona = h5;
            arista64.peso = -0.297;

            NeuronaConPeso arista65 = new NeuronaConPeso();
            arista65.neurona = h5;
            arista65.peso = 0.163;

            NeuronaConPeso arista66 = new NeuronaConPeso();
            arista66.neurona = h5;
            arista66.peso = 0.285;

            NeuronaConPeso arista67 = new NeuronaConPeso();
            arista67.neurona = h6;
            arista67.peso = 0.163;

            NeuronaConPeso arista68 = new NeuronaConPeso();
            arista68.neurona = h6;
            arista68.peso = 0.477;

            NeuronaConPeso arista69 = new NeuronaConPeso();
            arista69.neurona = h6;
            arista69.peso = -0.318;

            NeuronaConPeso arista70 = new NeuronaConPeso();
            arista70.neurona = h6;
            arista70.peso = -0.275;

            NeuronaConPeso arista71 = new NeuronaConPeso();
            arista71.neurona = h6;
            arista71.peso = -0.126;

            NeuronaConPeso arista72 = new NeuronaConPeso();
            arista72.neurona = h6;
            arista72.peso = 0.289;

            NeuronaConPeso arista73 = new NeuronaConPeso();
            arista73.neurona = i7;
            arista73.peso = -0.149;

            NeuronaConPeso arista74 = new NeuronaConPeso();
            arista74.neurona = i7;
            arista74.peso = -0.319;

            NeuronaConPeso arista75 = new NeuronaConPeso();
            arista75.neurona = i7;
            arista75.peso = 0.413;

            NeuronaConPeso arista76 = new NeuronaConPeso();
            arista76.neurona = i7;
            arista76.peso = 0.275;

            NeuronaConPeso arista77 = new NeuronaConPeso();
            arista77.neurona = i7;
            arista77.peso = -0.031;

            NeuronaConPeso arista78 = new NeuronaConPeso();
            arista78.neurona = i7;
            arista78.peso = 0.301;

            NeuronaConPeso arista79 = new NeuronaConPeso();
            arista79.neurona = i8;
            arista79.peso = 0.301;

            NeuronaConPeso arista80 = new NeuronaConPeso();
            arista80.neurona = i8;
            arista80.peso = -0.241;

            NeuronaConPeso arista81 = new NeuronaConPeso();
            arista81.neurona = i8;
            arista81.peso = 0.442;

            NeuronaConPeso arista82 = new NeuronaConPeso();
            arista82.neurona = i8;
            arista82.peso = 0.234;

            NeuronaConPeso arista83 = new NeuronaConPeso();
            arista83.neurona = i8;
            arista83.peso = -0.173;

            NeuronaConPeso arista84 = new NeuronaConPeso();
            arista84.neurona = i8;
            arista84.peso = -0.389;

            NeuronaConPeso arista85 = new NeuronaConPeso();
            arista85.neurona = i9;
            arista85.peso = 0.171;

            NeuronaConPeso arista86 = new NeuronaConPeso();
            arista86.neurona = i9;
            arista86.peso = 0.441;

            NeuronaConPeso arista87 = new NeuronaConPeso();
            arista87.neurona = i9;
            arista87.peso = 0.275;

            NeuronaConPeso arista88 = new NeuronaConPeso();
            arista88.neurona = i9;
            arista88.peso = -0.091;

            NeuronaConPeso arista89 = new NeuronaConPeso();
            arista89.neurona = i9;
            arista89.peso = 0.347;

            NeuronaConPeso arista90 = new NeuronaConPeso();
            arista90.neurona = i9;
            arista90.peso = -0.5;

            NeuronaConPeso arista91 = new NeuronaConPeso();
            arista91.neurona = i10;
            arista91.peso = 0.390;

            NeuronaConPeso arista92 = new NeuronaConPeso();
            arista92.neurona = i10;
            arista92.peso = -0.263;

            NeuronaConPeso arista93 = new NeuronaConPeso();
            arista93.neurona = i10;
            arista93.peso = 0.491;

            NeuronaConPeso arista94 = new NeuronaConPeso();
            arista94.neurona = i10;
            arista94.peso = -0.184;

            NeuronaConPeso arista95 = new NeuronaConPeso();
            arista95.neurona = i10;
            arista95.peso = -0.023;

            NeuronaConPeso arista96 = new NeuronaConPeso();
            arista96.neurona = i10;
            arista96.peso = 0.227;

            NeuronaConPeso arista97 = new NeuronaConPeso();
            arista97.neurona = i11;
            arista97.peso = -0.431;

            NeuronaConPeso arista98 = new NeuronaConPeso();
            arista98.neurona = i11;
            arista98.peso = 0.342;

            NeuronaConPeso arista99 = new NeuronaConPeso();
            arista99.neurona = i11;
            arista99.peso = -0.121;

            NeuronaConPeso arista100 = new NeuronaConPeso();
            arista100.neurona = i11;
            arista100.peso = 0.134;

            NeuronaConPeso arista101 = new NeuronaConPeso();
            arista101.neurona = i11;
            arista101.peso = 0.264;

            NeuronaConPeso arista102 = new NeuronaConPeso();
            arista102.neurona = i11;
            arista102.peso = -0.293;

            NeuronaConPeso arista103 = new NeuronaConPeso();
            arista103.neurona = i12;
            arista103.peso = -0.409;

            NeuronaConPeso arista104 = new NeuronaConPeso();
            arista104.neurona = i12;
            arista104.peso = -0.169;

            NeuronaConPeso arista105 = new NeuronaConPeso();
            arista105.neurona = i12;
            arista105.peso = -0.283;

            NeuronaConPeso arista106 = new NeuronaConPeso();
            arista106.neurona = i12;
            arista106.peso = 0.327;

            NeuronaConPeso arista107 = new NeuronaConPeso();
            arista107.neurona = i12;
            arista107.peso = 0.071;

            NeuronaConPeso arista108 = new NeuronaConPeso();
            arista108.neurona = i12;
            arista108.peso = 0.277;

            NeuronaConPeso arista109 = new NeuronaConPeso();
            arista109.neurona = i13;
            arista109.peso = 0.421;

            NeuronaConPeso arista110 = new NeuronaConPeso();
            arista110.neurona = i13;
            arista110.peso = 0.312;

            NeuronaConPeso arista111 = new NeuronaConPeso();
            arista111.neurona = i13;
            arista111.peso = 0.098;

            NeuronaConPeso arista112 = new NeuronaConPeso();
            arista112.neurona = i13;
            arista112.peso = -0.3079;

            NeuronaConPeso arista113 = new NeuronaConPeso();
            arista113.neurona = i13;
            arista113.peso = -0.182;

            NeuronaConPeso arista114 = new NeuronaConPeso();
            arista114.neurona = i13;
            arista114.peso = -0.242;

            NeuronaConPeso arista115 = new NeuronaConPeso();
            arista115.neurona = i14;
            arista115.peso = -0.423;

            NeuronaConPeso arista116 = new NeuronaConPeso();
            arista116.neurona = i14;
            arista116.peso = -0.1498;

            NeuronaConPeso arista117 = new NeuronaConPeso();
            arista117.neurona = i14;
            arista117.peso = -0.2467;

            NeuronaConPeso arista118 = new NeuronaConPeso();
            arista118.neurona = i14;
            arista118.peso = 0.0938;

            NeuronaConPeso arista119 = new NeuronaConPeso();
            arista119.neurona = i14;
            arista119.peso = 0.5;

            NeuronaConPeso arista120 = new NeuronaConPeso();
            arista120.neurona = i14;
            arista120.peso = 0.3847;

            NeuronaConPeso arista121 = new NeuronaConPeso();
            arista121.neurona = i15;
            arista121.peso = -0.2129;

            NeuronaConPeso arista122 = new NeuronaConPeso();
            arista122.neurona = i15;
            arista122.peso = -0.1489;

            NeuronaConPeso arista123 = new NeuronaConPeso();
            arista123.neurona = i15;
            arista123.peso = -0.4984;

            NeuronaConPeso arista124 = new NeuronaConPeso();
            arista124.neurona = i15;
            arista124.peso = 0.3849;

            NeuronaConPeso arista125 = new NeuronaConPeso();
            arista125.neurona = i15;
            arista125.peso = 0.1034;

            NeuronaConPeso arista126 = new NeuronaConPeso();
            arista126.neurona = i15;
            arista126.peso = 0.5;

            NeuronaConPeso arista127 = new NeuronaConPeso();
            arista127.neurona = i16;
            arista127.peso = 0.139;

            NeuronaConPeso arista128 = new NeuronaConPeso();
            arista128.neurona = i16;
            arista128.peso = -0.439;

            NeuronaConPeso arista129 = new NeuronaConPeso();
            arista129.neurona = i16;
            arista129.peso = -0.211;

            NeuronaConPeso arista130 = new NeuronaConPeso();
            arista130.neurona = i16;
            arista130.peso = 0.3934;

            NeuronaConPeso arista131 = new NeuronaConPeso();
            arista131.neurona = i16;
            arista131.peso = 0.2634;

            NeuronaConPeso arista132 = new NeuronaConPeso();
            arista132.neurona = i16;
            arista132.peso = 0.1094;

            NeuronaConPeso arista133 = new NeuronaConPeso();
            arista133.neurona = i17;
            arista133.peso = 0.1894;

            NeuronaConPeso arista134 = new NeuronaConPeso();
            arista134.neurona = i17;
            arista134.peso = 0.2014;

            NeuronaConPeso arista135 = new NeuronaConPeso();
            arista135.neurona = i17;
            arista135.peso = 0.45;

            NeuronaConPeso arista136 = new NeuronaConPeso();
            arista136.neurona = i17;
            arista136.peso = -0.428;

            NeuronaConPeso arista137 = new NeuronaConPeso();
            arista137.neurona = i17;
            arista137.peso = -0.287;

            NeuronaConPeso arista138 = new NeuronaConPeso();
            arista138.neurona = i17;
            arista138.peso = -0.1345;

            NeuronaConPeso arista139 = new NeuronaConPeso();
            arista139.neurona = i18;
            arista139.peso = -0.1345;

            NeuronaConPeso arista140 = new NeuronaConPeso();
            arista140.neurona = i18;
            arista140.peso = -0.4745;

            NeuronaConPeso arista141 = new NeuronaConPeso();
            arista141.neurona = i18;
            arista141.peso = -0.2914;

            NeuronaConPeso arista142 = new NeuronaConPeso();
            arista142.neurona = i18;
            arista142.peso = 0.0982;

            NeuronaConPeso arista143 = new NeuronaConPeso();
            arista143.neurona = i18;
            arista143.peso = 0.2234;

            NeuronaConPeso arista144 = new NeuronaConPeso();
            arista144.neurona = i18;
            arista144.peso = 0.1135;

            NeuronaConPeso arista145 = new NeuronaConPeso();
            arista145.neurona = i19;
            arista145.peso = -0.2135;

            NeuronaConPeso arista146 = new NeuronaConPeso();
            arista146.neurona = i19;
            arista146.peso = -0.4435;

            NeuronaConPeso arista147 = new NeuronaConPeso();
            arista147.neurona = i19;
            arista147.peso = -0.1784;

            NeuronaConPeso arista148 = new NeuronaConPeso();
            arista148.neurona = i19;
            arista148.peso = 0.2345;

            NeuronaConPeso arista149 = new NeuronaConPeso();
            arista149.neurona = i19;
            arista149.peso = 0.3456;

            NeuronaConPeso arista150 = new NeuronaConPeso();
            arista150.neurona = i19;
            arista150.peso = 0.4;

            NeuronaConPeso arista151 = new NeuronaConPeso();
            arista151.neurona = i20;
            arista151.peso = -0.234;

            NeuronaConPeso arista152 = new NeuronaConPeso();
            arista152.neurona = i20;
            arista152.peso = -0.413;

            NeuronaConPeso arista153 = new NeuronaConPeso();
            arista153.neurona = i20;
            arista153.peso = -0.130;

            NeuronaConPeso arista154 = new NeuronaConPeso();
            arista154.neurona = i20;
            arista154.peso = 0.1036;

            NeuronaConPeso arista155 = new NeuronaConPeso();
            arista155.neurona = i20;
            arista155.peso = 0.246;

            NeuronaConPeso arista156 = new NeuronaConPeso();
            arista156.neurona = i20;
            arista156.peso = -0.314;

            NeuronaConPeso arista157 = new NeuronaConPeso();
            arista157.neurona = i21;
            arista157.peso = 0.316;

            NeuronaConPeso arista158 = new NeuronaConPeso();
            arista158.neurona = i21;
            arista158.peso = 0.142;

            NeuronaConPeso arista159 = new NeuronaConPeso();
            arista159.neurona = i21;
            arista159.peso = 0.2903;

            NeuronaConPeso arista160 = new NeuronaConPeso();
            arista160.neurona = i21;
            arista160.peso = -0.458;

            NeuronaConPeso arista161 = new NeuronaConPeso();
            arista161.neurona = i21;
            arista161.peso = -0.1302;

            NeuronaConPeso arista162 = new NeuronaConPeso();
            arista162.neurona = i21;
            arista162.peso = -0.2469;

            NeuronaConPeso arista163 = new NeuronaConPeso();
            arista163.neurona = i22;
            arista163.peso = -0.1666;

            NeuronaConPeso arista164 = new NeuronaConPeso();
            arista164.neurona = i22;
            arista164.peso = -0.342;

            NeuronaConPeso arista165 = new NeuronaConPeso();
            arista165.neurona = i22;
            arista165.peso = -0.2943;

            NeuronaConPeso arista166 = new NeuronaConPeso();
            arista166.neurona = i22;
            arista166.peso = 0.1998;

            NeuronaConPeso arista167 = new NeuronaConPeso();
            arista167.neurona = i22;
            arista167.peso = 0.2859;

            NeuronaConPeso arista168 = new NeuronaConPeso();
            arista168.neurona = i22;
            arista168.peso = 0.3830;

            NeuronaConPeso arista169 = new NeuronaConPeso();
            arista169.neurona = i23;
            arista169.peso = 0.3830;

            NeuronaConPeso arista170 = new NeuronaConPeso();
            arista170.neurona = i23;
            arista170.peso = 0.1094;

            NeuronaConPeso arista171 = new NeuronaConPeso();
            arista171.neurona = i23;
            arista171.peso = 0.2476;

            NeuronaConPeso arista172 = new NeuronaConPeso();
            arista172.neurona = i23;
            arista172.peso = -0.4829;

            NeuronaConPeso arista173 = new NeuronaConPeso();
            arista173.neurona = i23;
            arista173.peso = -0.3234;

            NeuronaConPeso arista174 = new NeuronaConPeso();
            arista174.neurona = i23;
            arista174.peso = -0.1287;

            NeuronaConPeso arista175 = new NeuronaConPeso();
            arista175.neurona = i24;
            arista175.peso = -0.2246;

            NeuronaConPeso arista176 = new NeuronaConPeso();
            arista176.neurona = i24;
            arista176.peso = 0.3496;

            NeuronaConPeso arista177 = new NeuronaConPeso();
            arista177.neurona = i24;
            arista177.peso = -0.1224;

            NeuronaConPeso arista178 = new NeuronaConPeso();
            arista178.neurona = i24;
            arista178.peso = 0.4098;

            NeuronaConPeso arista179 = new NeuronaConPeso();
            arista179.neurona = i24;
            arista179.peso = 0.1673;

            NeuronaConPeso arista180 = new NeuronaConPeso();
            arista180.neurona = i24;
            arista180.peso = -0.3593;

            NeuronaConPeso arista181 = new NeuronaConPeso();
            arista181.neurona = i25;
            arista181.peso = -0.2948;

            NeuronaConPeso arista182 = new NeuronaConPeso();
            arista182.neurona = i25;
            arista182.peso = 0.2023;

            NeuronaConPeso arista183 = new NeuronaConPeso();
            arista183.neurona = i25;
            arista183.peso = -0.1494;

            NeuronaConPeso arista184 = new NeuronaConPeso();
            arista184.neurona = i25;
            arista184.peso = -0.3947;

            NeuronaConPeso arista185 = new NeuronaConPeso();
            arista185.neurona = i25;
            arista185.peso = 0.5;

            NeuronaConPeso arista186 = new NeuronaConPeso();
            arista186.neurona = i25;
            arista186.peso = 0.1313;

            NeuronaConPeso arista187 = new NeuronaConPeso();
            arista187.neurona = i26;
            arista187.peso = 0.3278;

            NeuronaConPeso arista188 = new NeuronaConPeso();
            arista188.neurona = i26;
            arista188.peso = 0.4721;

            NeuronaConPeso arista189 = new NeuronaConPeso();
            arista189.neurona = i26;
            arista189.peso = -0.1366;

            NeuronaConPeso arista190 = new NeuronaConPeso();
            arista190.neurona = i26;
            arista190.peso = -0.2993;

            NeuronaConPeso arista191 = new NeuronaConPeso();
            arista191.neurona = i26;
            arista191.peso = -0.4444;

            NeuronaConPeso arista192 = new NeuronaConPeso();
            arista192.neurona = i26;
            arista192.peso = 0.1182;

            NeuronaConPeso arista193 = new NeuronaConPeso();
            arista193.neurona = i27;
            arista193.peso = 0.0931;

            NeuronaConPeso arista194 = new NeuronaConPeso();
            arista194.neurona = i27;
            arista194.peso = -0.5;

            NeuronaConPeso arista195 = new NeuronaConPeso();
            arista195.neurona = i27;
            arista195.peso = 0.4;

            NeuronaConPeso arista196 = new NeuronaConPeso();
            arista196.neurona = i27;
            arista196.peso = -0.0481;

            NeuronaConPeso arista197 = new NeuronaConPeso();
            arista197.neurona = i27;
            arista197.peso = -0.3213;

            NeuronaConPeso arista198 = new NeuronaConPeso();
            arista198.neurona = i27;
            arista198.peso = 0.3853;

            NeuronaConPeso arista199 = new NeuronaConPeso();
            arista199.neurona = i28;
            arista199.peso = 0.2573;

            NeuronaConPeso arista200 = new NeuronaConPeso();
            arista200.neurona = i28;
            arista200.peso = 0.1038;

            NeuronaConPeso arista201 = new NeuronaConPeso();
            arista201.neurona = i28;
            arista201.peso = 0.3495;

            NeuronaConPeso arista202 = new NeuronaConPeso();
            arista202.neurona = i28;
            arista202.peso = -0.1503;

            NeuronaConPeso arista203 = new NeuronaConPeso();
            arista203.neurona = i28;
            arista203.peso = -0.2389;

            NeuronaConPeso arista204 = new NeuronaConPeso();
            arista204.neurona = i28;
            arista204.peso = -0.4215;

            NeuronaConPeso arista205 = new NeuronaConPeso();
            arista205.neurona = i29;
            arista205.peso = -0.1483;

            NeuronaConPeso arista206 = new NeuronaConPeso();
            arista206.neurona = i29;
            arista206.peso = -0.2348;

            NeuronaConPeso arista207 = new NeuronaConPeso();
            arista207.neurona = i29;
            arista207.peso = -0.3968;

            NeuronaConPeso arista208 = new NeuronaConPeso();
            arista208.neurona = i29;
            arista208.peso = 0.3246;

            NeuronaConPeso arista209 = new NeuronaConPeso();
            arista209.neurona = i29;
            arista209.peso = 0.2153;

            NeuronaConPeso arista210 = new NeuronaConPeso();
            arista210.neurona = i29;
            arista210.peso = 0.4687;

            NeuronaConPeso arista211 = new NeuronaConPeso();
            arista211.neurona = i30;
            arista211.peso = 0.1646;

            NeuronaConPeso arista212 = new NeuronaConPeso();
            arista212.neurona = i30;
            arista212.peso = 0.4214;

            NeuronaConPeso arista213 = new NeuronaConPeso();
            arista213.neurona = i30;
            arista213.peso = 0.3859;

            NeuronaConPeso arista214 = new NeuronaConPeso();
            arista214.neurona = i30;
            arista214.peso = -0.0824;

            NeuronaConPeso arista215 = new NeuronaConPeso();
            arista215.neurona = i30;
            arista215.peso = -0.5;

            NeuronaConPeso arista216 = new NeuronaConPeso();
            arista216.neurona = i30;
            arista216.peso = -0.2;

            NeuronaConPeso arista217 = new NeuronaConPeso();
            arista217.neurona = i31;
            arista217.peso = 0.267;

            NeuronaConPeso arista218 = new NeuronaConPeso();
            arista218.neurona = i31;
            arista218.peso = 0.4345;

            NeuronaConPeso arista219 = new NeuronaConPeso();
            arista219.neurona = i31;
            arista219.peso = 0.1538;

            NeuronaConPeso arista220 = new NeuronaConPeso();
            arista220.neurona = i31;
            arista220.peso = -0.1346;

            NeuronaConPeso arista221 = new NeuronaConPeso();
            arista221.neurona = i31;
            arista221.peso = -0.4261;

            NeuronaConPeso arista222 = new NeuronaConPeso();
            arista222.neurona = i31;
            arista222.peso = -0.2297;

            NeuronaConPeso arista223 = new NeuronaConPeso();
            arista223.neurona = i32;
            arista223.peso = -0.4398;

            NeuronaConPeso arista224 = new NeuronaConPeso();
            arista224.neurona = i32;
            arista224.peso = -0.1363;

            NeuronaConPeso arista225 = new NeuronaConPeso();
            arista225.neurona = i32;
            arista225.peso = -0.2709;

            NeuronaConPeso arista226 = new NeuronaConPeso();
            arista226.neurona = i32;
            arista226.peso = 0.2491;

            NeuronaConPeso arista227 = new NeuronaConPeso();
            arista227.neurona = i32;
            arista227.peso = 0.3964;

            NeuronaConPeso arista228 = new NeuronaConPeso();
            arista228.neurona = i32;
            arista228.peso = 0.1693;

            NeuronaConPeso arista229 = new NeuronaConPeso();
            arista229.neurona = i33;
            arista229.peso = -0.2368;

            NeuronaConPeso arista230 = new NeuronaConPeso();
            arista230.neurona = i33;
            arista230.peso = -0.4085;

            NeuronaConPeso arista231 = new NeuronaConPeso();
            arista231.neurona = i33;
            arista231.peso = -0.0139;

            NeuronaConPeso arista232 = new NeuronaConPeso();
            arista232.neurona = i33;
            arista232.peso = 0.4567;

            NeuronaConPeso arista233 = new NeuronaConPeso();
            arista233.neurona = i33;
            arista233.peso = 0.2154;

            NeuronaConPeso arista234 = new NeuronaConPeso();
            arista234.neurona = i33;
            arista234.peso = 0.0483;

            NeuronaConPeso arista235 = new NeuronaConPeso();
            arista235.neurona = i34;
            arista235.peso = 0.2345;

            NeuronaConPeso arista236 = new NeuronaConPeso();
            arista236.neurona = i34;
            arista236.peso = 0.0436;

            NeuronaConPeso arista237 = new NeuronaConPeso();
            arista237.neurona = i34;
            arista237.peso = 0.4219;

            NeuronaConPeso arista238 = new NeuronaConPeso();
            arista238.neurona = i34;
            arista238.peso = -0.1368;

            NeuronaConPeso arista239 = new NeuronaConPeso();
            arista239.neurona = i34;
            arista239.peso = -0.3347;

            NeuronaConPeso arista240 = new NeuronaConPeso();
            arista240.neurona = i34;
            arista240.peso = -0.5;

            NeuronaConPeso arista241 = new NeuronaConPeso();
            arista241.neurona = i35;
            arista241.peso = -0.4343;

            NeuronaConPeso arista242 = new NeuronaConPeso();
            arista242.neurona = i35;
            arista242.peso = -0.2247;

            NeuronaConPeso arista243 = new NeuronaConPeso();
            arista243.neurona = i35;
            arista243.peso = -0.1367;

            NeuronaConPeso arista244 = new NeuronaConPeso();
            arista244.neurona = i35;
            arista244.peso = 0.2564;

            NeuronaConPeso arista245 = new NeuronaConPeso();
            arista245.neurona = i35;
            arista245.peso = 0.0398;

            NeuronaConPeso arista246 = new NeuronaConPeso();
            arista246.neurona = i35;
            arista246.peso = 0.4;

            NeuronaConPeso arista247 = new NeuronaConPeso();
            arista247.neurona = i36;
            arista247.peso = 0.3134;

            NeuronaConPeso arista248 = new NeuronaConPeso();
            arista248.neurona = i36;
            arista248.peso = 0.2957;

            NeuronaConPeso arista249 = new NeuronaConPeso();
            arista249.neurona = i36;
            arista249.peso = 0.1434;

            NeuronaConPeso arista250 = new NeuronaConPeso();
            arista250.neurona = i36;
            arista250.peso = -0.4675;

            NeuronaConPeso arista251 = new NeuronaConPeso();
            arista251.neurona = i36;
            arista251.peso = -0.0382;

            NeuronaConPeso arista252 = new NeuronaConPeso();
            arista252.neurona = i36;
            arista252.peso = -0.2589;

            NeuronaConPeso arista253 = new NeuronaConPeso();
            arista253.neurona = i1;
            arista253.peso = 0.2929;

            NeuronaConPeso arista254 = new NeuronaConPeso();
            arista254.neurona = i2;
            arista254.peso = 0.1269;

            NeuronaConPeso arista255 = new NeuronaConPeso();
            arista255.neurona = i3;
            arista255.peso = -0.3200;

            NeuronaConPeso arista256 = new NeuronaConPeso();
            arista256.neurona = i4;
            arista256.peso = -0.434;

            NeuronaConPeso arista257 = new NeuronaConPeso();
            arista257.neurona = i5;
            arista257.peso = 0.156;

            NeuronaConPeso arista258 = new NeuronaConPeso();
            arista258.neurona = i6;
            arista258.peso = 0.284;

            NeuronaConPeso arista259 = new NeuronaConPeso();
            arista259.neurona = i7;
            arista259.peso = -0.387;

            NeuronaConPeso arista260 = new NeuronaConPeso();
            arista260.neurona = i8;
            arista260.peso = -0.121;

            NeuronaConPeso arista261 = new NeuronaConPeso();
            arista261.neurona = i9;
            arista261.peso = 0.0214;

            NeuronaConPeso arista262 = new NeuronaConPeso();
            arista262.neurona = i10;
            arista262.peso = -0.336;

            NeuronaConPeso arista263 = new NeuronaConPeso();
            arista263.neurona = i11;
            arista263.peso = -0.5;

            NeuronaConPeso arista264 = new NeuronaConPeso();
            arista264.neurona = i12;
            arista264.peso = 0.413;

            NeuronaConPeso arista265 = new NeuronaConPeso();
            arista265.neurona = i13;
            arista265.peso = 0.167;

            NeuronaConPeso arista266 = new NeuronaConPeso();
            arista266.neurona = i14;
            arista266.peso = 0.238;

            NeuronaConPeso arista267 = new NeuronaConPeso();
            arista267.neurona = i15;
            arista267.peso = -0.115;

            NeuronaConPeso arista268 = new NeuronaConPeso();
            arista268.neurona = i16;
            arista268.peso = -0.265;

            NeuronaConPeso arista269 = new NeuronaConPeso();
            arista269.neurona = i17;
            arista269.peso = -0.371;

            NeuronaConPeso arista270 = new NeuronaConPeso();
            arista270.neurona = i18;
            arista270.peso = 0.457;

            NeuronaConPeso arista271 = new NeuronaConPeso();
            arista271.neurona = i19;
            arista271.peso = 0.113;

            NeuronaConPeso arista272 = new NeuronaConPeso();
            arista272.neurona = i20;
            arista272.peso = -0.374;

            NeuronaConPeso arista273 = new NeuronaConPeso();
            arista273.neurona = i21;
            arista273.peso = -0.222;

            NeuronaConPeso arista274 = new NeuronaConPeso();
            arista274.neurona = i22;
            arista274.peso = 0.274;

            NeuronaConPeso arista275 = new NeuronaConPeso();
            arista275.neurona = i23;
            arista275.peso = 0.401;

            NeuronaConPeso arista276 = new NeuronaConPeso();
            arista276.neurona = i24;
            arista276.peso = 0.375;

            NeuronaConPeso arista277 = new NeuronaConPeso();
            arista277.neurona = i25;
            arista277.peso = 0.194;

            NeuronaConPeso arista278 = new NeuronaConPeso();
            arista278.neurona = i26;
            arista278.peso = 0.093;

            NeuronaConPeso arista279 = new NeuronaConPeso();
            arista279.neurona = i27;
            arista279.peso = -0.345;

            NeuronaConPeso arista280 = new NeuronaConPeso();
            arista280.neurona = i28;
            arista280.peso = -0.291;

            NeuronaConPeso arista281 = new NeuronaConPeso();
            arista281.neurona = i29;
            arista281.peso = 0.409;

            NeuronaConPeso arista282 = new NeuronaConPeso();
            arista282.neurona = i30;
            arista282.peso = 0.147;

            NeuronaConPeso arista283 = new NeuronaConPeso();
            arista283.neurona = i31;
            arista283.peso = 0.241;

            NeuronaConPeso arista284 = new NeuronaConPeso();
            arista284.neurona = i32;
            arista284.peso = -0.285;

            NeuronaConPeso arista285 = new NeuronaConPeso();
            arista285.neurona = i33;
            arista285.peso = -0.3723;

            NeuronaConPeso arista286 = new NeuronaConPeso();
            arista286.neurona = i34;
            arista286.peso = 0.1724;

            NeuronaConPeso arista287 = new NeuronaConPeso();
            arista287.neurona = i35;
            arista287.peso = 0.2417;

            NeuronaConPeso arista288 = new NeuronaConPeso();
            arista288.neurona = i36;
            arista288.peso = -0.1605;

            NeuronaConPeso arista289 = new NeuronaConPeso();
            arista289.neurona = h7;
            arista289.peso = -0.4005;

            NeuronaConPeso arista290 = new NeuronaConPeso();
            arista290.neurona = h7;
            arista290.peso = -0.2893;

            NeuronaConPeso arista291 = new NeuronaConPeso();
            arista291.neurona = h7;
            arista291.peso = -0.1093;

            NeuronaConPeso arista292 = new NeuronaConPeso();
            arista292.neurona = h7;
            arista292.peso = 0.3890;

            NeuronaConPeso arista293 = new NeuronaConPeso();
            arista293.neurona = h7;
            arista293.peso = 0.1973;

            NeuronaConPeso arista294 = new NeuronaConPeso();
            arista294.neurona = h7;
            arista294.peso = 0.2363;

            //Agregaremos aristas para una neurona más: neurona h8.
            NeuronaConPeso arista295 = new NeuronaConPeso();
            arista295.neurona = i1;
            arista295.peso = 0.1094;

            NeuronaConPeso arista296 = new NeuronaConPeso();
            arista296.neurona = i2;
            arista296.peso = 0.2736;

            NeuronaConPeso arista297 = new NeuronaConPeso();
            arista297.neurona = i3;
            arista297.peso = -0.3275;

            NeuronaConPeso arista298 = new NeuronaConPeso();
            arista298.neurona = i4;
            arista298.peso = -0.134;

            NeuronaConPeso arista299 = new NeuronaConPeso();
            arista299.neurona = i5;
            arista299.peso = 0.174;

            NeuronaConPeso arista300 = new NeuronaConPeso();
            arista300.neurona = i6;
            arista300.peso = 0.278;

            NeuronaConPeso arista301 = new NeuronaConPeso();
            arista301.neurona = i7;
            arista301.peso = -0.194;

            NeuronaConPeso arista302 = new NeuronaConPeso();
            arista302.neurona = i8;
            arista302.peso = 0.467;

            NeuronaConPeso arista303 = new NeuronaConPeso();
            arista303.neurona = i9;
            arista303.peso = 0.0928;

            NeuronaConPeso arista304 = new NeuronaConPeso();
            arista304.neurona = i10;
            arista304.peso = -0.123;

            NeuronaConPeso arista305 = new NeuronaConPeso();
            arista305.neurona = i11;
            arista305.peso = 0.456;

            NeuronaConPeso arista306 = new NeuronaConPeso();
            arista306.neurona = i12;
            arista306.peso = -0.184;

            NeuronaConPeso arista307 = new NeuronaConPeso();
            arista307.neurona = i13;
            arista307.peso = 0.396;

            NeuronaConPeso arista308 = new NeuronaConPeso();
            arista308.neurona = i14;
            arista308.peso = 0.277;

            NeuronaConPeso arista309 = new NeuronaConPeso();
            arista309.neurona = i15;
            arista309.peso = -0.115;

            NeuronaConPeso arista310 = new NeuronaConPeso();
            arista310.neurona = i16;
            arista310.peso = 0.195;

            NeuronaConPeso arista311 = new NeuronaConPeso();
            arista311.neurona = i17;
            arista311.peso = 0.269;

            NeuronaConPeso arista312 = new NeuronaConPeso();
            arista312.neurona = i18;
            arista312.peso = 0.457;

            NeuronaConPeso arista313 = new NeuronaConPeso();
            arista313.neurona = i19;
            arista313.peso = 0.293;

            NeuronaConPeso arista314 = new NeuronaConPeso();
            arista314.neurona = i20;
            arista314.peso = 0.5;

            NeuronaConPeso arista315 = new NeuronaConPeso();
            arista315.neurona = i21;
            arista315.peso = 0.284;

            NeuronaConPeso arista316 = new NeuronaConPeso();
            arista316.neurona = i22;
            arista316.peso = -0.473;

            NeuronaConPeso arista317 = new NeuronaConPeso();
            arista317.neurona = i23;
            arista317.peso = 0.213;

            NeuronaConPeso arista318 = new NeuronaConPeso();
            arista318.neurona = i24;
            arista318.peso = -0.299;

            NeuronaConPeso arista319 = new NeuronaConPeso();
            arista319.neurona = i25;
            arista319.peso = -0.341;

            NeuronaConPeso arista320 = new NeuronaConPeso();
            arista320.neurona = i26;
            arista320.peso = -0.1;

            NeuronaConPeso arista321 = new NeuronaConPeso();
            arista321.neurona = i27;
            arista321.peso = -0.345;

            NeuronaConPeso arista322 = new NeuronaConPeso();
            arista322.neurona = i28;
            arista322.peso = 0.303;

            NeuronaConPeso arista323 = new NeuronaConPeso();
            arista323.neurona = i29;
            arista323.peso = -0.1666;

            NeuronaConPeso arista324 = new NeuronaConPeso();
            arista324.neurona = i30;
            arista324.peso = -0.2777;

            NeuronaConPeso arista325 = new NeuronaConPeso();
            arista325.neurona = i31;
            arista325.peso = -0.129;

            NeuronaConPeso arista326 = new NeuronaConPeso();
            arista326.neurona = i32;
            arista326.peso = 0.258;

            NeuronaConPeso arista327 = new NeuronaConPeso();
            arista327.neurona = i33;
            arista327.peso = 0.3987;

            NeuronaConPeso arista328 = new NeuronaConPeso();
            arista328.neurona = i34;
            arista328.peso = -0.1427;

            NeuronaConPeso arista329 = new NeuronaConPeso();
            arista329.neurona = i35;
            arista329.peso = -0.4223;

            NeuronaConPeso arista330 = new NeuronaConPeso();
            arista330.neurona = i36;
            arista330.peso = 0.216;

            NeuronaConPeso arista331 = new NeuronaConPeso();
            arista331.neurona = h8;
            arista331.peso = -0.2717;

            NeuronaConPeso arista332 = new NeuronaConPeso();
            arista332.neurona = h8;
            arista332.peso = -0.3411;

            NeuronaConPeso arista333 = new NeuronaConPeso();
            arista333.neurona = h8;
            arista333.peso = -0.3742;

            NeuronaConPeso arista334 = new NeuronaConPeso();
            arista334.neurona = h8;
            arista334.peso = 0.4121;

            NeuronaConPeso arista335 = new NeuronaConPeso();
            arista335.neurona = h8;
            arista335.peso = 0.1030;

            NeuronaConPeso arista336 = new NeuronaConPeso();
            arista336.neurona = h8;
            arista336.peso = 0.5;


            //Enlazando grafo: Aristas para las neuronas de capa inicial a capa oculta
            i1.agregarNeuronaDeIda(arista1);
            h1.agregarNeuronaDeLlegada(arista1);
            i1.agregarNeuronaDeIda(arista2);
            h2.agregarNeuronaDeLlegada(arista2);
            i1.agregarNeuronaDeIda(arista3);
            h3.agregarNeuronaDeLlegada(arista3);
            i1.agregarNeuronaDeIda(arista4);
            h4.agregarNeuronaDeLlegada(arista4);
            i1.agregarNeuronaDeIda(arista5);
            h5.agregarNeuronaDeLlegada(arista5);
            i1.agregarNeuronaDeIda(arista6);
            h6.agregarNeuronaDeLlegada(arista6);
            i1.agregarNeuronaDeIda(arista253);
            h7.agregarNeuronaDeLlegada(arista253);
            i1.agregarNeuronaDeIda(arista295);
            h8.agregarNeuronaDeLlegada(arista295);

            i2.agregarNeuronaDeIda(arista7);
            h1.agregarNeuronaDeLlegada(arista7);
            i2.agregarNeuronaDeIda(arista8);
            h2.agregarNeuronaDeLlegada(arista8);
            i2.agregarNeuronaDeIda(arista9);
            h3.agregarNeuronaDeLlegada(arista9);
            i2.agregarNeuronaDeIda(arista10);
            h4.agregarNeuronaDeLlegada(arista10);
            i2.agregarNeuronaDeIda(arista11);
            h5.agregarNeuronaDeLlegada(arista11);
            i2.agregarNeuronaDeIda(arista12);
            h6.agregarNeuronaDeLlegada(arista12);
            i2.agregarNeuronaDeIda(arista254);
            h7.agregarNeuronaDeLlegada(arista254);
            i2.agregarNeuronaDeIda(arista296);
            h8.agregarNeuronaDeLlegada(arista296);

            i3.agregarNeuronaDeIda(arista13);
            h1.agregarNeuronaDeLlegada(arista13);
            i3.agregarNeuronaDeIda(arista14);
            h2.agregarNeuronaDeLlegada(arista14);
            i3.agregarNeuronaDeIda(arista15);
            h3.agregarNeuronaDeLlegada(arista15);
            i3.agregarNeuronaDeIda(arista16);
            h4.agregarNeuronaDeLlegada(arista16);
            i3.agregarNeuronaDeIda(arista17);
            h5.agregarNeuronaDeLlegada(arista17);
            i3.agregarNeuronaDeIda(arista18);
            h6.agregarNeuronaDeLlegada(arista18);
            i3.agregarNeuronaDeIda(arista255);
            h7.agregarNeuronaDeLlegada(arista255);
            i3.agregarNeuronaDeIda(arista297);
            h8.agregarNeuronaDeLlegada(arista297);

            i4.agregarNeuronaDeIda(arista19);
            h1.agregarNeuronaDeLlegada(arista19);
            i4.agregarNeuronaDeIda(arista20);
            h2.agregarNeuronaDeLlegada(arista20);
            i4.agregarNeuronaDeIda(arista21);
            h3.agregarNeuronaDeLlegada(arista21);
            i4.agregarNeuronaDeIda(arista22);
            h4.agregarNeuronaDeLlegada(arista22);
            i4.agregarNeuronaDeIda(arista23);
            h5.agregarNeuronaDeLlegada(arista23);
            i4.agregarNeuronaDeIda(arista24);
            h6.agregarNeuronaDeLlegada(arista24);
            i4.agregarNeuronaDeIda(arista256);
            h7.agregarNeuronaDeLlegada(arista256);
            i4.agregarNeuronaDeIda(arista298);
            h8.agregarNeuronaDeLlegada(arista298);

            i5.agregarNeuronaDeIda(arista25);
            h1.agregarNeuronaDeLlegada(arista25);
            i5.agregarNeuronaDeIda(arista26);
            h2.agregarNeuronaDeLlegada(arista26);
            i5.agregarNeuronaDeIda(arista27);
            h3.agregarNeuronaDeLlegada(arista27);
            i5.agregarNeuronaDeIda(arista28);
            h4.agregarNeuronaDeLlegada(arista28);
            i5.agregarNeuronaDeIda(arista29);
            h5.agregarNeuronaDeLlegada(arista29);
            i5.agregarNeuronaDeIda(arista30);
            h6.agregarNeuronaDeLlegada(arista30);
            i5.agregarNeuronaDeIda(arista257);
            h7.agregarNeuronaDeLlegada(arista257);
            i5.agregarNeuronaDeIda(arista299);
            h8.agregarNeuronaDeLlegada(arista299);

            i6.agregarNeuronaDeIda(arista31);
            h1.agregarNeuronaDeLlegada(arista31);
            i6.agregarNeuronaDeIda(arista32);
            h2.agregarNeuronaDeLlegada(arista32);
            i6.agregarNeuronaDeIda(arista33);
            h3.agregarNeuronaDeLlegada(arista33);
            i6.agregarNeuronaDeIda(arista34);
            h4.agregarNeuronaDeLlegada(arista34);
            i6.agregarNeuronaDeIda(arista35);
            h5.agregarNeuronaDeLlegada(arista35);
            i6.agregarNeuronaDeIda(arista36);
            h6.agregarNeuronaDeLlegada(arista36);
            i6.agregarNeuronaDeIda(arista258);
            h7.agregarNeuronaDeLlegada(arista258);
            i6.agregarNeuronaDeIda(arista300);
            h8.agregarNeuronaDeLlegada(arista300);

            i7.agregarNeuronaDeIda(arista73);
            h1.agregarNeuronaDeLlegada(arista73);
            i7.agregarNeuronaDeIda(arista74);
            h2.agregarNeuronaDeLlegada(arista74);
            i7.agregarNeuronaDeIda(arista75);
            h3.agregarNeuronaDeLlegada(arista75);
            i7.agregarNeuronaDeIda(arista76);
            h4.agregarNeuronaDeLlegada(arista76);
            i7.agregarNeuronaDeIda(arista77);
            h5.agregarNeuronaDeLlegada(arista77);
            i7.agregarNeuronaDeIda(arista78);
            h6.agregarNeuronaDeLlegada(arista78);
            i7.agregarNeuronaDeIda(arista259);
            h7.agregarNeuronaDeLlegada(arista259);
            i7.agregarNeuronaDeIda(arista301);
            h8.agregarNeuronaDeLlegada(arista301);

            i8.agregarNeuronaDeIda(arista79);
            h1.agregarNeuronaDeLlegada(arista79);
            i8.agregarNeuronaDeIda(arista80);
            h2.agregarNeuronaDeLlegada(arista80);
            i8.agregarNeuronaDeIda(arista81);
            h3.agregarNeuronaDeLlegada(arista81);
            i8.agregarNeuronaDeIda(arista82);
            h4.agregarNeuronaDeLlegada(arista82);
            i8.agregarNeuronaDeIda(arista83);
            h5.agregarNeuronaDeLlegada(arista83);
            i8.agregarNeuronaDeIda(arista84);
            h6.agregarNeuronaDeLlegada(arista84);
            i8.agregarNeuronaDeIda(arista260);
            h7.agregarNeuronaDeLlegada(arista260);
            i8.agregarNeuronaDeIda(arista302);
            h8.agregarNeuronaDeLlegada(arista302);

            i9.agregarNeuronaDeIda(arista85);
            h1.agregarNeuronaDeLlegada(arista85);
            i9.agregarNeuronaDeIda(arista86);
            h2.agregarNeuronaDeLlegada(arista86);
            i9.agregarNeuronaDeIda(arista87);
            h3.agregarNeuronaDeLlegada(arista87);
            i9.agregarNeuronaDeIda(arista88);
            h4.agregarNeuronaDeLlegada(arista88);
            i9.agregarNeuronaDeIda(arista89);
            h5.agregarNeuronaDeLlegada(arista89);
            i9.agregarNeuronaDeIda(arista90);
            h6.agregarNeuronaDeLlegada(arista90);
            i9.agregarNeuronaDeIda(arista261);
            h7.agregarNeuronaDeLlegada(arista261);
            i9.agregarNeuronaDeIda(arista303);
            h8.agregarNeuronaDeLlegada(arista303);

            i10.agregarNeuronaDeIda(arista91);
            h1.agregarNeuronaDeLlegada(arista91);
            i10.agregarNeuronaDeIda(arista92);
            h2.agregarNeuronaDeLlegada(arista92);
            i10.agregarNeuronaDeIda(arista93);
            h3.agregarNeuronaDeLlegada(arista93);
            i10.agregarNeuronaDeIda(arista94);
            h4.agregarNeuronaDeLlegada(arista94);
            i10.agregarNeuronaDeIda(arista95);
            h5.agregarNeuronaDeLlegada(arista95);
            i10.agregarNeuronaDeIda(arista96);
            h6.agregarNeuronaDeLlegada(arista96);
            i10.agregarNeuronaDeIda(arista262);
            h7.agregarNeuronaDeLlegada(arista262);
            i10.agregarNeuronaDeIda(arista304);
            h8.agregarNeuronaDeLlegada(arista304);

            i11.agregarNeuronaDeIda(arista97);
            h1.agregarNeuronaDeLlegada(arista97);
            i11.agregarNeuronaDeIda(arista98);
            h2.agregarNeuronaDeLlegada(arista98);
            i11.agregarNeuronaDeIda(arista99);
            h3.agregarNeuronaDeLlegada(arista99);
            i11.agregarNeuronaDeIda(arista100);
            h4.agregarNeuronaDeLlegada(arista100);
            i11.agregarNeuronaDeIda(arista101);
            h5.agregarNeuronaDeLlegada(arista101);
            i11.agregarNeuronaDeIda(arista102);
            h6.agregarNeuronaDeLlegada(arista102);
            i11.agregarNeuronaDeIda(arista263);
            h7.agregarNeuronaDeLlegada(arista263);
            i11.agregarNeuronaDeIda(arista305);
            h8.agregarNeuronaDeLlegada(arista305);

            i12.agregarNeuronaDeIda(arista103);
            h1.agregarNeuronaDeLlegada(arista103);
            i12.agregarNeuronaDeIda(arista104);
            h2.agregarNeuronaDeLlegada(arista104);
            i12.agregarNeuronaDeIda(arista105);
            h3.agregarNeuronaDeLlegada(arista105);
            i12.agregarNeuronaDeIda(arista106);
            h4.agregarNeuronaDeLlegada(arista106);
            i12.agregarNeuronaDeIda(arista107);
            h5.agregarNeuronaDeLlegada(arista107);
            i12.agregarNeuronaDeIda(arista108);
            h6.agregarNeuronaDeLlegada(arista108);
            i12.agregarNeuronaDeIda(arista264);
            h7.agregarNeuronaDeLlegada(arista264);
            i12.agregarNeuronaDeIda(arista306);
            h8.agregarNeuronaDeLlegada(arista306);

            i13.agregarNeuronaDeIda(arista109);
            h1.agregarNeuronaDeLlegada(arista109);
            i13.agregarNeuronaDeIda(arista110);
            h2.agregarNeuronaDeLlegada(arista110);
            i13.agregarNeuronaDeIda(arista111);
            h3.agregarNeuronaDeLlegada(arista111);
            i13.agregarNeuronaDeIda(arista112);
            h4.agregarNeuronaDeLlegada(arista112);
            i13.agregarNeuronaDeIda(arista113);
            h5.agregarNeuronaDeLlegada(arista113);
            i13.agregarNeuronaDeIda(arista114);
            h6.agregarNeuronaDeLlegada(arista114);
            i13.agregarNeuronaDeIda(arista265);
            h7.agregarNeuronaDeLlegada(arista265);
            i13.agregarNeuronaDeIda(arista307);
            h8.agregarNeuronaDeLlegada(arista307);

            i14.agregarNeuronaDeIda(arista115);
            h1.agregarNeuronaDeLlegada(arista115);
            i14.agregarNeuronaDeIda(arista116);
            h2.agregarNeuronaDeLlegada(arista116);
            i14.agregarNeuronaDeIda(arista117);
            h3.agregarNeuronaDeLlegada(arista117);
            i14.agregarNeuronaDeIda(arista118);
            h4.agregarNeuronaDeLlegada(arista118);
            i14.agregarNeuronaDeIda(arista119);
            h5.agregarNeuronaDeLlegada(arista119);
            i14.agregarNeuronaDeIda(arista120);
            h6.agregarNeuronaDeLlegada(arista120);
            i14.agregarNeuronaDeIda(arista266);
            h7.agregarNeuronaDeLlegada(arista266);
            i14.agregarNeuronaDeIda(arista308);
            h8.agregarNeuronaDeLlegada(arista308);

            i15.agregarNeuronaDeIda(arista121);
            h1.agregarNeuronaDeLlegada(arista121);
            i15.agregarNeuronaDeIda(arista122);
            h2.agregarNeuronaDeLlegada(arista122);
            i15.agregarNeuronaDeIda(arista123);
            h3.agregarNeuronaDeLlegada(arista123);
            i15.agregarNeuronaDeIda(arista124);
            h4.agregarNeuronaDeLlegada(arista124);
            i15.agregarNeuronaDeIda(arista125);
            h5.agregarNeuronaDeLlegada(arista125);
            i15.agregarNeuronaDeIda(arista126);
            h6.agregarNeuronaDeLlegada(arista126);
            i15.agregarNeuronaDeIda(arista267);
            h7.agregarNeuronaDeLlegada(arista267);
            i15.agregarNeuronaDeIda(arista309);
            h8.agregarNeuronaDeLlegada(arista309);

            i16.agregarNeuronaDeIda(arista127);
            h1.agregarNeuronaDeLlegada(arista127);
            i16.agregarNeuronaDeIda(arista128);
            h2.agregarNeuronaDeLlegada(arista128);
            i16.agregarNeuronaDeIda(arista129);
            h3.agregarNeuronaDeLlegada(arista129);
            i16.agregarNeuronaDeIda(arista130);
            h4.agregarNeuronaDeLlegada(arista130);
            i16.agregarNeuronaDeIda(arista131);
            h5.agregarNeuronaDeLlegada(arista131);
            i16.agregarNeuronaDeIda(arista132);
            h6.agregarNeuronaDeLlegada(arista132);
            i16.agregarNeuronaDeIda(arista268);
            h7.agregarNeuronaDeLlegada(arista268);
            i16.agregarNeuronaDeIda(arista310);
            h8.agregarNeuronaDeLlegada(arista310);

            i17.agregarNeuronaDeIda(arista133);
            h1.agregarNeuronaDeLlegada(arista133);
            i17.agregarNeuronaDeIda(arista134);
            h2.agregarNeuronaDeLlegada(arista134);
            i17.agregarNeuronaDeIda(arista135);
            h3.agregarNeuronaDeLlegada(arista135);
            i17.agregarNeuronaDeIda(arista136);
            h4.agregarNeuronaDeLlegada(arista136);
            i17.agregarNeuronaDeIda(arista137);
            h5.agregarNeuronaDeLlegada(arista137);
            i17.agregarNeuronaDeIda(arista138);
            h6.agregarNeuronaDeLlegada(arista138);
            i17.agregarNeuronaDeIda(arista269);
            h7.agregarNeuronaDeLlegada(arista269);
            i17.agregarNeuronaDeIda(arista311);
            h8.agregarNeuronaDeLlegada(arista311);

            i18.agregarNeuronaDeIda(arista139);
            h1.agregarNeuronaDeLlegada(arista139);
            i18.agregarNeuronaDeIda(arista140);
            h2.agregarNeuronaDeLlegada(arista140);
            i18.agregarNeuronaDeIda(arista141);
            h3.agregarNeuronaDeLlegada(arista141);
            i18.agregarNeuronaDeIda(arista142);
            h4.agregarNeuronaDeLlegada(arista142);
            i18.agregarNeuronaDeIda(arista143);
            h5.agregarNeuronaDeLlegada(arista143);
            i18.agregarNeuronaDeIda(arista144);
            h6.agregarNeuronaDeLlegada(arista144);
            i18.agregarNeuronaDeIda(arista270);
            h7.agregarNeuronaDeLlegada(arista270);
            i18.agregarNeuronaDeIda(arista312);
            h8.agregarNeuronaDeLlegada(arista312);

            i19.agregarNeuronaDeIda(arista145);
            h1.agregarNeuronaDeLlegada(arista145);
            i19.agregarNeuronaDeIda(arista146);
            h2.agregarNeuronaDeLlegada(arista146);
            i19.agregarNeuronaDeIda(arista147);
            h3.agregarNeuronaDeLlegada(arista147);
            i19.agregarNeuronaDeIda(arista148);
            h4.agregarNeuronaDeLlegada(arista148);
            i19.agregarNeuronaDeIda(arista149);
            h5.agregarNeuronaDeLlegada(arista149);
            i19.agregarNeuronaDeIda(arista150);
            h6.agregarNeuronaDeLlegada(arista150);
            i19.agregarNeuronaDeIda(arista271);
            h7.agregarNeuronaDeLlegada(arista271);
            i19.agregarNeuronaDeIda(arista313);
            h8.agregarNeuronaDeLlegada(arista313);

            i20.agregarNeuronaDeIda(arista151);
            h1.agregarNeuronaDeLlegada(arista151);
            i20.agregarNeuronaDeIda(arista152);
            h2.agregarNeuronaDeLlegada(arista152);
            i20.agregarNeuronaDeIda(arista153);
            h3.agregarNeuronaDeLlegada(arista153);
            i20.agregarNeuronaDeIda(arista154);
            h4.agregarNeuronaDeLlegada(arista154);
            i20.agregarNeuronaDeIda(arista155);
            h5.agregarNeuronaDeLlegada(arista155);
            i20.agregarNeuronaDeIda(arista156);
            h6.agregarNeuronaDeLlegada(arista156);
            i20.agregarNeuronaDeIda(arista272);
            h7.agregarNeuronaDeLlegada(arista272);
            i20.agregarNeuronaDeIda(arista314);
            h8.agregarNeuronaDeLlegada(arista314);

            i21.agregarNeuronaDeIda(arista157);
            h1.agregarNeuronaDeLlegada(arista157);
            i21.agregarNeuronaDeIda(arista158);
            h2.agregarNeuronaDeLlegada(arista158);
            i21.agregarNeuronaDeIda(arista159);
            h3.agregarNeuronaDeLlegada(arista159);
            i21.agregarNeuronaDeIda(arista160);
            h4.agregarNeuronaDeLlegada(arista160);
            i21.agregarNeuronaDeIda(arista161);
            h5.agregarNeuronaDeLlegada(arista161);
            i21.agregarNeuronaDeIda(arista162);
            h6.agregarNeuronaDeLlegada(arista162);
            i21.agregarNeuronaDeIda(arista273);
            h7.agregarNeuronaDeLlegada(arista273);
            i21.agregarNeuronaDeIda(arista315);
            h8.agregarNeuronaDeLlegada(arista315);

            i22.agregarNeuronaDeIda(arista163);
            h1.agregarNeuronaDeLlegada(arista163);
            i22.agregarNeuronaDeIda(arista164);
            h2.agregarNeuronaDeLlegada(arista164);
            i22.agregarNeuronaDeIda(arista165);
            h3.agregarNeuronaDeLlegada(arista165);
            i22.agregarNeuronaDeIda(arista166);
            h4.agregarNeuronaDeLlegada(arista166);
            i22.agregarNeuronaDeIda(arista167);
            h5.agregarNeuronaDeLlegada(arista167);
            i22.agregarNeuronaDeIda(arista168);
            h6.agregarNeuronaDeLlegada(arista168);
            i22.agregarNeuronaDeIda(arista274);
            h7.agregarNeuronaDeLlegada(arista274);
            i22.agregarNeuronaDeIda(arista316);
            h8.agregarNeuronaDeLlegada(arista316);

            i23.agregarNeuronaDeIda(arista169);
            h1.agregarNeuronaDeLlegada(arista169);
            i23.agregarNeuronaDeIda(arista170);
            h2.agregarNeuronaDeLlegada(arista170);
            i23.agregarNeuronaDeIda(arista171);
            h3.agregarNeuronaDeLlegada(arista171);
            i23.agregarNeuronaDeIda(arista172);
            h4.agregarNeuronaDeLlegada(arista172);
            i23.agregarNeuronaDeIda(arista173);
            h5.agregarNeuronaDeLlegada(arista173);
            i23.agregarNeuronaDeIda(arista174);
            h6.agregarNeuronaDeLlegada(arista174);
            i23.agregarNeuronaDeIda(arista275);
            h7.agregarNeuronaDeLlegada(arista275);
            i23.agregarNeuronaDeIda(arista317);
            h8.agregarNeuronaDeLlegada(arista317);

            i24.agregarNeuronaDeIda(arista175);
            h1.agregarNeuronaDeLlegada(arista175);
            i24.agregarNeuronaDeIda(arista176);
            h2.agregarNeuronaDeLlegada(arista176);
            i24.agregarNeuronaDeIda(arista177);
            h3.agregarNeuronaDeLlegada(arista177);
            i24.agregarNeuronaDeIda(arista178);
            h4.agregarNeuronaDeLlegada(arista178);
            i24.agregarNeuronaDeIda(arista179);
            h5.agregarNeuronaDeLlegada(arista179);
            i24.agregarNeuronaDeIda(arista180);
            h6.agregarNeuronaDeLlegada(arista180);
            i24.agregarNeuronaDeIda(arista276);
            h7.agregarNeuronaDeLlegada(arista276);
            i24.agregarNeuronaDeIda(arista318);
            h8.agregarNeuronaDeLlegada(arista318);

            i25.agregarNeuronaDeIda(arista181);
            h1.agregarNeuronaDeLlegada(arista181);
            i25.agregarNeuronaDeIda(arista182);
            h2.agregarNeuronaDeLlegada(arista182);
            i25.agregarNeuronaDeIda(arista183);
            h3.agregarNeuronaDeLlegada(arista183);
            i25.agregarNeuronaDeIda(arista184);
            h4.agregarNeuronaDeLlegada(arista184);
            i25.agregarNeuronaDeIda(arista185);
            h5.agregarNeuronaDeLlegada(arista185);
            i25.agregarNeuronaDeIda(arista186);
            h6.agregarNeuronaDeLlegada(arista186);
            i25.agregarNeuronaDeIda(arista277);
            h7.agregarNeuronaDeLlegada(arista277);
            i25.agregarNeuronaDeIda(arista319);
            h8.agregarNeuronaDeLlegada(arista319);

            i26.agregarNeuronaDeIda(arista187);
            h1.agregarNeuronaDeLlegada(arista187);
            i26.agregarNeuronaDeIda(arista188);
            h2.agregarNeuronaDeLlegada(arista188);
            i26.agregarNeuronaDeIda(arista189);
            h3.agregarNeuronaDeLlegada(arista189);
            i26.agregarNeuronaDeIda(arista190);
            h4.agregarNeuronaDeLlegada(arista190);
            i26.agregarNeuronaDeIda(arista191);
            h5.agregarNeuronaDeLlegada(arista191);
            i26.agregarNeuronaDeIda(arista192);
            h6.agregarNeuronaDeLlegada(arista192);
            i26.agregarNeuronaDeIda(arista278);
            h7.agregarNeuronaDeLlegada(arista278);
            i26.agregarNeuronaDeIda(arista320);
            h8.agregarNeuronaDeLlegada(arista320);

            i27.agregarNeuronaDeIda(arista193);
            h1.agregarNeuronaDeLlegada(arista193);
            i27.agregarNeuronaDeIda(arista194);
            h2.agregarNeuronaDeLlegada(arista194);
            i27.agregarNeuronaDeIda(arista195);
            h3.agregarNeuronaDeLlegada(arista195);
            i27.agregarNeuronaDeIda(arista196);
            h4.agregarNeuronaDeLlegada(arista196);
            i27.agregarNeuronaDeIda(arista197);
            h5.agregarNeuronaDeLlegada(arista197);
            i27.agregarNeuronaDeIda(arista198);
            h6.agregarNeuronaDeLlegada(arista198);
            i27.agregarNeuronaDeIda(arista279);
            h7.agregarNeuronaDeLlegada(arista279);
            i27.agregarNeuronaDeIda(arista321);
            h8.agregarNeuronaDeLlegada(arista321);

            i28.agregarNeuronaDeIda(arista199);
            h1.agregarNeuronaDeLlegada(arista199);
            i28.agregarNeuronaDeIda(arista200);
            h2.agregarNeuronaDeLlegada(arista200);
            i28.agregarNeuronaDeIda(arista201);
            h3.agregarNeuronaDeLlegada(arista201);
            i28.agregarNeuronaDeIda(arista202);
            h4.agregarNeuronaDeLlegada(arista202);
            i28.agregarNeuronaDeIda(arista203);
            h5.agregarNeuronaDeLlegada(arista203);
            i28.agregarNeuronaDeIda(arista204);
            h6.agregarNeuronaDeLlegada(arista204);
            i28.agregarNeuronaDeIda(arista280);
            h7.agregarNeuronaDeLlegada(arista280);
            i28.agregarNeuronaDeIda(arista322);
            h8.agregarNeuronaDeLlegada(arista322);

            i29.agregarNeuronaDeIda(arista205);
            h1.agregarNeuronaDeLlegada(arista205);
            i29.agregarNeuronaDeIda(arista206);
            h2.agregarNeuronaDeLlegada(arista206);
            i29.agregarNeuronaDeIda(arista207);
            h3.agregarNeuronaDeLlegada(arista207);
            i29.agregarNeuronaDeIda(arista208);
            h4.agregarNeuronaDeLlegada(arista208);
            i29.agregarNeuronaDeIda(arista209);
            h5.agregarNeuronaDeLlegada(arista209);
            i29.agregarNeuronaDeIda(arista210);
            h6.agregarNeuronaDeLlegada(arista210);
            i29.agregarNeuronaDeIda(arista281);
            h7.agregarNeuronaDeLlegada(arista281);
            i29.agregarNeuronaDeIda(arista323);
            h8.agregarNeuronaDeLlegada(arista323);

            i30.agregarNeuronaDeIda(arista211);
            h1.agregarNeuronaDeLlegada(arista211);
            i30.agregarNeuronaDeIda(arista212);
            h2.agregarNeuronaDeLlegada(arista212);
            i30.agregarNeuronaDeIda(arista213);
            h3.agregarNeuronaDeLlegada(arista213);
            i30.agregarNeuronaDeIda(arista214);
            h4.agregarNeuronaDeLlegada(arista214);
            i30.agregarNeuronaDeIda(arista215);
            h5.agregarNeuronaDeLlegada(arista215);
            i30.agregarNeuronaDeIda(arista216);
            h6.agregarNeuronaDeLlegada(arista216);
            i30.agregarNeuronaDeIda(arista282);
            h7.agregarNeuronaDeLlegada(arista282);
            i30.agregarNeuronaDeIda(arista324);
            h8.agregarNeuronaDeLlegada(arista324);

            i31.agregarNeuronaDeIda(arista217);
            h1.agregarNeuronaDeLlegada(arista217);
            i31.agregarNeuronaDeIda(arista218);
            h2.agregarNeuronaDeLlegada(arista218);
            i31.agregarNeuronaDeIda(arista219);
            h3.agregarNeuronaDeLlegada(arista219);
            i31.agregarNeuronaDeIda(arista220);
            h4.agregarNeuronaDeLlegada(arista220);
            i31.agregarNeuronaDeIda(arista221);
            h5.agregarNeuronaDeLlegada(arista221);
            i31.agregarNeuronaDeIda(arista222);
            h6.agregarNeuronaDeLlegada(arista222);
            i31.agregarNeuronaDeIda(arista283);
            h7.agregarNeuronaDeLlegada(arista283);
            i31.agregarNeuronaDeIda(arista325);
            h8.agregarNeuronaDeLlegada(arista325);

            i32.agregarNeuronaDeIda(arista223);
            h1.agregarNeuronaDeLlegada(arista223);
            i32.agregarNeuronaDeIda(arista224);
            h2.agregarNeuronaDeLlegada(arista224);
            i32.agregarNeuronaDeIda(arista225);
            h3.agregarNeuronaDeLlegada(arista225);
            i32.agregarNeuronaDeIda(arista226);
            h4.agregarNeuronaDeLlegada(arista226);
            i32.agregarNeuronaDeIda(arista227);
            h5.agregarNeuronaDeLlegada(arista227);
            i32.agregarNeuronaDeIda(arista228);
            h6.agregarNeuronaDeLlegada(arista228);
            i32.agregarNeuronaDeIda(arista284);
            h7.agregarNeuronaDeLlegada(arista284);
            i32.agregarNeuronaDeIda(arista326);
            h8.agregarNeuronaDeLlegada(arista326);

            i33.agregarNeuronaDeIda(arista229);
            h1.agregarNeuronaDeLlegada(arista229);
            i33.agregarNeuronaDeIda(arista230);
            h2.agregarNeuronaDeLlegada(arista230);
            i33.agregarNeuronaDeIda(arista231);
            h3.agregarNeuronaDeLlegada(arista231);
            i33.agregarNeuronaDeIda(arista232);
            h4.agregarNeuronaDeLlegada(arista232);
            i33.agregarNeuronaDeIda(arista233);
            h5.agregarNeuronaDeLlegada(arista233);
            i33.agregarNeuronaDeIda(arista234);
            h6.agregarNeuronaDeLlegada(arista234);
            i33.agregarNeuronaDeIda(arista285);
            h7.agregarNeuronaDeLlegada(arista285);
            i33.agregarNeuronaDeIda(arista327);
            h8.agregarNeuronaDeLlegada(arista327);

            i34.agregarNeuronaDeIda(arista235);
            h1.agregarNeuronaDeLlegada(arista235);
            i34.agregarNeuronaDeIda(arista236);
            h2.agregarNeuronaDeLlegada(arista236);
            i34.agregarNeuronaDeIda(arista237);
            h3.agregarNeuronaDeLlegada(arista237);
            i34.agregarNeuronaDeIda(arista238);
            h4.agregarNeuronaDeLlegada(arista238);
            i34.agregarNeuronaDeIda(arista239);
            h5.agregarNeuronaDeLlegada(arista239);
            i34.agregarNeuronaDeIda(arista240);
            h6.agregarNeuronaDeLlegada(arista240);
            i34.agregarNeuronaDeIda(arista286);
            h7.agregarNeuronaDeLlegada(arista286);
            i34.agregarNeuronaDeIda(arista328);
            h8.agregarNeuronaDeLlegada(arista328);

            i35.agregarNeuronaDeIda(arista241);
            h1.agregarNeuronaDeLlegada(arista241);
            i35.agregarNeuronaDeIda(arista242);
            h2.agregarNeuronaDeLlegada(arista242);
            i35.agregarNeuronaDeIda(arista243);
            h3.agregarNeuronaDeLlegada(arista243);
            i35.agregarNeuronaDeIda(arista244);
            h4.agregarNeuronaDeLlegada(arista244);
            i35.agregarNeuronaDeIda(arista245);
            h5.agregarNeuronaDeLlegada(arista245);
            i35.agregarNeuronaDeIda(arista246);
            h6.agregarNeuronaDeLlegada(arista246);
            i35.agregarNeuronaDeIda(arista287);
            h7.agregarNeuronaDeLlegada(arista287);
            i35.agregarNeuronaDeIda(arista329);
            h8.agregarNeuronaDeLlegada(arista329);

            i36.agregarNeuronaDeIda(arista247);
            h1.agregarNeuronaDeLlegada(arista247);
            i36.agregarNeuronaDeIda(arista248);
            h2.agregarNeuronaDeLlegada(arista248);
            i36.agregarNeuronaDeIda(arista249);
            h3.agregarNeuronaDeLlegada(arista249);
            i36.agregarNeuronaDeIda(arista250);
            h4.agregarNeuronaDeLlegada(arista250);
            i36.agregarNeuronaDeIda(arista251);
            h5.agregarNeuronaDeLlegada(arista251);
            i36.agregarNeuronaDeIda(arista252);
            h6.agregarNeuronaDeLlegada(arista252);
            i36.agregarNeuronaDeIda(arista288);
            h7.agregarNeuronaDeLlegada(arista288);
            i36.agregarNeuronaDeIda(arista330);
            h8.agregarNeuronaDeLlegada(arista330);

            //Enlazando grafo: Aristas para las neuronas de capa oculta a capa salida.
            h1.agregarNeuronaDeIda(arista37);
            o1.agregarNeuronaDeLlegada(arista37);
            h1.agregarNeuronaDeIda(arista38);
            o2.agregarNeuronaDeLlegada(arista38);
            h1.agregarNeuronaDeIda(arista39);
            o3.agregarNeuronaDeLlegada(arista39);
            h1.agregarNeuronaDeIda(arista40);
            o4.agregarNeuronaDeLlegada(arista40);
            h1.agregarNeuronaDeIda(arista41);
            o5.agregarNeuronaDeLlegada(arista41);
            h1.agregarNeuronaDeIda(arista42);
            o6.agregarNeuronaDeLlegada(arista42);

            h2.agregarNeuronaDeIda(arista43);
            o1.agregarNeuronaDeLlegada(arista43);
            h2.agregarNeuronaDeIda(arista44);
            o2.agregarNeuronaDeLlegada(arista44);
            h2.agregarNeuronaDeIda(arista45);
            o3.agregarNeuronaDeLlegada(arista45);
            h2.agregarNeuronaDeIda(arista46);
            o4.agregarNeuronaDeLlegada(arista46);
            h2.agregarNeuronaDeIda(arista47);
            o5.agregarNeuronaDeLlegada(arista47);
            h2.agregarNeuronaDeIda(arista48);
            o6.agregarNeuronaDeLlegada(arista48);

            h3.agregarNeuronaDeIda(arista49);
            o1.agregarNeuronaDeLlegada(arista49);
            h3.agregarNeuronaDeIda(arista50);
            o2.agregarNeuronaDeLlegada(arista50);
            h3.agregarNeuronaDeIda(arista51);
            o3.agregarNeuronaDeLlegada(arista51);
            h3.agregarNeuronaDeIda(arista52);
            o4.agregarNeuronaDeLlegada(arista52);
            h3.agregarNeuronaDeIda(arista53);
            o5.agregarNeuronaDeLlegada(arista53);
            h3.agregarNeuronaDeIda(arista54);
            o6.agregarNeuronaDeLlegada(arista54);

            h4.agregarNeuronaDeIda(arista55);
            o1.agregarNeuronaDeLlegada(arista55);
            h4.agregarNeuronaDeIda(arista56);
            o2.agregarNeuronaDeLlegada(arista56);
            h4.agregarNeuronaDeIda(arista57);
            o3.agregarNeuronaDeLlegada(arista57);
            h4.agregarNeuronaDeIda(arista58);
            o4.agregarNeuronaDeLlegada(arista58);
            h4.agregarNeuronaDeIda(arista59);
            o5.agregarNeuronaDeLlegada(arista59);
            h4.agregarNeuronaDeIda(arista60);
            o6.agregarNeuronaDeLlegada(arista60);

            h5.agregarNeuronaDeIda(arista61);
            o1.agregarNeuronaDeLlegada(arista61);
            h5.agregarNeuronaDeIda(arista62);
            o2.agregarNeuronaDeLlegada(arista62);
            h5.agregarNeuronaDeIda(arista63);
            o3.agregarNeuronaDeLlegada(arista63);
            h5.agregarNeuronaDeIda(arista64);
            o4.agregarNeuronaDeLlegada(arista64);
            h5.agregarNeuronaDeIda(arista65);
            o5.agregarNeuronaDeLlegada(arista65);
            h5.agregarNeuronaDeIda(arista66);
            o6.agregarNeuronaDeLlegada(arista66);

            h6.agregarNeuronaDeIda(arista67);
            o1.agregarNeuronaDeLlegada(arista67);
            h6.agregarNeuronaDeIda(arista68);
            o2.agregarNeuronaDeLlegada(arista68);
            h6.agregarNeuronaDeIda(arista69);
            o3.agregarNeuronaDeLlegada(arista69);
            h6.agregarNeuronaDeIda(arista70);
            o4.agregarNeuronaDeLlegada(arista70);
            h6.agregarNeuronaDeIda(arista71);
            o5.agregarNeuronaDeLlegada(arista71);
            h6.agregarNeuronaDeIda(arista72);
            o6.agregarNeuronaDeLlegada(arista72);

            h7.agregarNeuronaDeIda(arista289);
            o1.agregarNeuronaDeLlegada(arista289);
            h7.agregarNeuronaDeIda(arista290);
            o2.agregarNeuronaDeLlegada(arista290);
            h7.agregarNeuronaDeIda(arista291);
            o3.agregarNeuronaDeLlegada(arista291);
            h7.agregarNeuronaDeIda(arista292);
            o4.agregarNeuronaDeLlegada(arista292);
            h7.agregarNeuronaDeIda(arista293);
            o5.agregarNeuronaDeLlegada(arista293);
            h7.agregarNeuronaDeIda(arista294);
            o6.agregarNeuronaDeLlegada(arista294);

            h8.agregarNeuronaDeIda(arista331);
            o1.agregarNeuronaDeLlegada(arista331);
            h8.agregarNeuronaDeIda(arista332);
            o2.agregarNeuronaDeLlegada(arista332);
            h8.agregarNeuronaDeIda(arista333);
            o3.agregarNeuronaDeLlegada(arista333);
            h8.agregarNeuronaDeIda(arista334);
            o4.agregarNeuronaDeLlegada(arista334);
            h8.agregarNeuronaDeIda(arista335);
            o5.agregarNeuronaDeLlegada(arista335);
            h8.agregarNeuronaDeIda(arista336);
            o6.agregarNeuronaDeLlegada(arista336);

            // Pasando información a la instancia de backpropagation            
            Neurona[] arrayNeuronas = { i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, i17, i18, i19,
                                         i20, i21, i22, i23, i24, i25, i26, i27, i28, i29, i30, i31, i32, i33, i34, i35, i36,
                                          h1, h2, h3, h4, h5, h6, h7, h8, o1, o2, o3, o4, o5, o6 };

            //backpropagation.tasaDeAprendizaje = 0.35;
            backpropagation.tasaDeAprendizaje = 0.25;

            backpropagation.neuronas = new List<Neurona>(arrayNeuronas);

        }

        /// <summary>
        /// crea la tabla de caracteres 
        /// </summary>
        /// <param name="backpropagation">instancia de la clase de backpropagation</param>
        public void createCharactersTable(Backpropagation backpropagation)
        {
            //backpropagation = new Retropropagación();
            Patron n0 = new Patron("0");
            Patron n1 = new Patron("1");
            Patron n2 = new Patron("2");
            Patron n3 = new Patron("3");
            Patron n4 = new Patron("4");
            Patron n5 = new Patron("5");
            Patron n6 = new Patron("6");
            Patron n7 = new Patron("7");
            Patron n8 = new Patron("8");
            Patron n9 = new Patron("9");
            Patron A = new Patron("A");
            Patron B = new Patron("B");
            Patron C = new Patron("C");
            Patron D = new Patron("D");
            Patron E = new Patron("E");
            Patron F = new Patron("F");
            Patron G = new Patron("G");
            Patron H = new Patron("H");
            Patron I = new Patron("I");
            Patron J = new Patron("J");
            Patron K = new Patron("K");
            Patron L = new Patron("L");
            Patron M = new Patron("M");
            Patron N = new Patron("N");
            Patron O = new Patron("O");
            Patron P = new Patron("P");
            Patron Q = new Patron("Q");
            Patron R = new Patron("R");
            Patron S = new Patron("S");
            Patron T = new Patron("T");
            Patron U = new Patron("U");
            Patron V = new Patron("V");
            Patron W = new Patron("W");
            Patron X = new Patron("X");
            Patron Y = new Patron("Y");
            Patron Z = new Patron("Z");
            //--------------------------------------------------------------------------------------------
            n0.agregarEntrada(new PatronItem("x1", 0));
            n0.agregarEntrada(new PatronItem("x2", 1));
            n0.agregarEntrada(new PatronItem("x3", 1));
            n0.agregarEntrada(new PatronItem("x4", 1));
            n0.agregarEntrada(new PatronItem("x5", 1));
            n0.agregarEntrada(new PatronItem("x6", 0));

            n0.agregarEntrada(new PatronItem("x7", 0));
            n0.agregarEntrada(new PatronItem("x8", 1));
            n0.agregarEntrada(new PatronItem("x9", 0));
            n0.agregarEntrada(new PatronItem("x10", 0));
            n0.agregarEntrada(new PatronItem("x11", 1));
            n0.agregarEntrada(new PatronItem("x12", 0));

            n0.agregarEntrada(new PatronItem("x13", 0));
            n0.agregarEntrada(new PatronItem("x14", 1));
            n0.agregarEntrada(new PatronItem("x15", 0));
            n0.agregarEntrada(new PatronItem("x16", 0));
            n0.agregarEntrada(new PatronItem("x17", 1));
            n0.agregarEntrada(new PatronItem("x18", 0));

            n0.agregarEntrada(new PatronItem("x19", 0));
            n0.agregarEntrada(new PatronItem("x20", 1));
            n0.agregarEntrada(new PatronItem("x21", 0));
            n0.agregarEntrada(new PatronItem("x22", 0));
            n0.agregarEntrada(new PatronItem("x23", 1));
            n0.agregarEntrada(new PatronItem("x24", 0));

            n0.agregarEntrada(new PatronItem("x25", 0));
            n0.agregarEntrada(new PatronItem("x26", 1));
            n0.agregarEntrada(new PatronItem("x27", 0));
            n0.agregarEntrada(new PatronItem("x28", 0));
            n0.agregarEntrada(new PatronItem("x29", 1));
            n0.agregarEntrada(new PatronItem("x30", 0));

            n0.agregarEntrada(new PatronItem("x31", 0));
            n0.agregarEntrada(new PatronItem("x32", 1));
            n0.agregarEntrada(new PatronItem("x33", 1));
            n0.agregarEntrada(new PatronItem("x34", 1));
            n0.agregarEntrada(new PatronItem("x35", 1));
            n0.agregarEntrada(new PatronItem("x36", 0));

            n0.agregarSalida(new PatronItem("t1", 0));
            n0.agregarSalida(new PatronItem("t2", 0));
            n0.agregarSalida(new PatronItem("t3", 0));
            n0.agregarSalida(new PatronItem("t4", 0));
            n0.agregarSalida(new PatronItem("t5", 0));
            n0.agregarSalida(new PatronItem("t6", 0));
            //---------------------------------------------------------------------------------------
            n1.agregarEntrada(new PatronItem("x1", 0));
            n1.agregarEntrada(new PatronItem("x2", 0));
            n1.agregarEntrada(new PatronItem("x3", 1));
            n1.agregarEntrada(new PatronItem("x4", 1));
            n1.agregarEntrada(new PatronItem("x5", 0));
            n1.agregarEntrada(new PatronItem("x6", 0));

            n1.agregarEntrada(new PatronItem("x7", 0));
            n1.agregarEntrada(new PatronItem("x8", 1));
            n1.agregarEntrada(new PatronItem("x9", 1));
            n1.agregarEntrada(new PatronItem("x10", 1));
            n1.agregarEntrada(new PatronItem("x11", 0));
            n1.agregarEntrada(new PatronItem("x12", 0));

            n1.agregarEntrada(new PatronItem("x13", 0));
            n1.agregarEntrada(new PatronItem("x14", 0));
            n1.agregarEntrada(new PatronItem("x15", 1));
            n1.agregarEntrada(new PatronItem("x16", 1));
            n1.agregarEntrada(new PatronItem("x17", 0));
            n1.agregarEntrada(new PatronItem("x18", 0));

            n1.agregarEntrada(new PatronItem("x19", 0));
            n1.agregarEntrada(new PatronItem("x20", 0));
            n1.agregarEntrada(new PatronItem("x21", 1));
            n1.agregarEntrada(new PatronItem("x22", 1));
            n1.agregarEntrada(new PatronItem("x23", 0));
            n1.agregarEntrada(new PatronItem("x24", 0));

            n1.agregarEntrada(new PatronItem("x25", 0));
            n1.agregarEntrada(new PatronItem("x26", 0));
            n1.agregarEntrada(new PatronItem("x27", 1));
            n1.agregarEntrada(new PatronItem("x28", 1));
            n1.agregarEntrada(new PatronItem("x29", 0));
            n1.agregarEntrada(new PatronItem("x30", 0));

            n1.agregarEntrada(new PatronItem("x31", 0));
            n1.agregarEntrada(new PatronItem("x32", 1));
            n1.agregarEntrada(new PatronItem("x33", 1));
            n1.agregarEntrada(new PatronItem("x34", 1));
            n1.agregarEntrada(new PatronItem("x35", 1));
            n1.agregarEntrada(new PatronItem("x36", 0));

            n1.agregarSalida(new PatronItem("t1", 0));
            n1.agregarSalida(new PatronItem("t2", 0));
            n1.agregarSalida(new PatronItem("t3", 0));
            n1.agregarSalida(new PatronItem("t4", 0));
            n1.agregarSalida(new PatronItem("t5", 0));
            n1.agregarSalida(new PatronItem("t6", 1));
            //------------------------------------------------------------------------------
            n2.agregarEntrada(new PatronItem("x1", 1));
            n2.agregarEntrada(new PatronItem("x2", 1));
            n2.agregarEntrada(new PatronItem("x3", 1));
            n2.agregarEntrada(new PatronItem("x4", 1));
            n2.agregarEntrada(new PatronItem("x5", 1));
            n2.agregarEntrada(new PatronItem("x6", 0));

            n2.agregarEntrada(new PatronItem("x7", 0));
            n2.agregarEntrada(new PatronItem("x8", 0));
            n2.agregarEntrada(new PatronItem("x9", 0));
            n2.agregarEntrada(new PatronItem("x10", 0));
            n2.agregarEntrada(new PatronItem("x11", 0));
            n2.agregarEntrada(new PatronItem("x12", 1));

            n2.agregarEntrada(new PatronItem("x13", 0));
            n2.agregarEntrada(new PatronItem("x14", 0));
            n2.agregarEntrada(new PatronItem("x15", 0));
            n2.agregarEntrada(new PatronItem("x16", 1));
            n2.agregarEntrada(new PatronItem("x17", 1));
            n2.agregarEntrada(new PatronItem("x18", 0));

            n2.agregarEntrada(new PatronItem("x19", 0));
            n2.agregarEntrada(new PatronItem("x20", 0));
            n2.agregarEntrada(new PatronItem("x21", 1));
            n2.agregarEntrada(new PatronItem("x22", 0));
            n2.agregarEntrada(new PatronItem("x23", 0));
            n2.agregarEntrada(new PatronItem("x24", 0));

            n2.agregarEntrada(new PatronItem("x25", 0));
            n2.agregarEntrada(new PatronItem("x26", 1));
            n2.agregarEntrada(new PatronItem("x27", 0));
            n2.agregarEntrada(new PatronItem("x28", 0));
            n2.agregarEntrada(new PatronItem("x29", 0));
            n2.agregarEntrada(new PatronItem("x30", 0));

            n2.agregarEntrada(new PatronItem("x31", 1));
            n2.agregarEntrada(new PatronItem("x32", 1));
            n2.agregarEntrada(new PatronItem("x33", 1));
            n2.agregarEntrada(new PatronItem("x34", 1));
            n2.agregarEntrada(new PatronItem("x35", 1));
            n2.agregarEntrada(new PatronItem("x36", 1));

            n2.agregarSalida(new PatronItem("t1", 0));
            n2.agregarSalida(new PatronItem("t2", 0));
            n2.agregarSalida(new PatronItem("t3", 0));
            n2.agregarSalida(new PatronItem("t4", 0));
            n2.agregarSalida(new PatronItem("t5", 1));
            n2.agregarSalida(new PatronItem("t6", 0));

            n3.agregarEntrada(new PatronItem("x1", 0));
            n3.agregarEntrada(new PatronItem("x2", 1));
            n3.agregarEntrada(new PatronItem("x3", 1));
            n3.agregarEntrada(new PatronItem("x4", 1));
            n3.agregarEntrada(new PatronItem("x5", 1));
            n3.agregarEntrada(new PatronItem("x6", 1));
            n3.agregarEntrada(new PatronItem("x7", 0));
            n3.agregarEntrada(new PatronItem("x8", 0));
            n3.agregarEntrada(new PatronItem("x9", 0));
            n3.agregarEntrada(new PatronItem("x10", 0));
            n3.agregarEntrada(new PatronItem("x11", 0));
            n3.agregarEntrada(new PatronItem("x12", 1));
            n3.agregarEntrada(new PatronItem("x13", 0));
            n3.agregarEntrada(new PatronItem("x14", 1));
            n3.agregarEntrada(new PatronItem("x15", 1));
            n3.agregarEntrada(new PatronItem("x16", 1));
            n3.agregarEntrada(new PatronItem("x17", 1));
            n3.agregarEntrada(new PatronItem("x18", 1));
            n3.agregarEntrada(new PatronItem("x19", 0));
            n3.agregarEntrada(new PatronItem("x20", 0));
            n3.agregarEntrada(new PatronItem("x21", 0));
            n3.agregarEntrada(new PatronItem("x22", 0));
            n3.agregarEntrada(new PatronItem("x23", 0));
            n3.agregarEntrada(new PatronItem("x24", 1));
            n3.agregarEntrada(new PatronItem("x25", 0));
            n3.agregarEntrada(new PatronItem("x26", 0));
            n3.agregarEntrada(new PatronItem("x27", 0));
            n3.agregarEntrada(new PatronItem("x28", 0));
            n3.agregarEntrada(new PatronItem("x29", 0));
            n3.agregarEntrada(new PatronItem("x30", 1));
            n3.agregarEntrada(new PatronItem("x31", 0));
            n3.agregarEntrada(new PatronItem("x32", 1));
            n3.agregarEntrada(new PatronItem("x33", 1));
            n3.agregarEntrada(new PatronItem("x34", 1));
            n3.agregarEntrada(new PatronItem("x35", 1));
            n3.agregarEntrada(new PatronItem("x36", 1));
            n3.agregarSalida(new PatronItem("t1", 0));
            n3.agregarSalida(new PatronItem("t2", 0));
            n3.agregarSalida(new PatronItem("t3", 0));
            n3.agregarSalida(new PatronItem("t4", 0));
            n3.agregarSalida(new PatronItem("t5", 1));
            n3.agregarSalida(new PatronItem("t6", 1));

            n4.agregarEntrada(new PatronItem("x1", 0));
            n4.agregarEntrada(new PatronItem("x2", 1));
            n4.agregarEntrada(new PatronItem("x3", 0));
            n4.agregarEntrada(new PatronItem("x4", 0));
            n4.agregarEntrada(new PatronItem("x5", 0));
            n4.agregarEntrada(new PatronItem("x6", 1));
            n4.agregarEntrada(new PatronItem("x7", 0));
            n4.agregarEntrada(new PatronItem("x8", 1));
            n4.agregarEntrada(new PatronItem("x9", 0));
            n4.agregarEntrada(new PatronItem("x10", 0));
            n4.agregarEntrada(new PatronItem("x11", 0));
            n4.agregarEntrada(new PatronItem("x12", 1));
            n4.agregarEntrada(new PatronItem("x13", 0));
            n4.agregarEntrada(new PatronItem("x14", 1));
            n4.agregarEntrada(new PatronItem("x15", 1));
            n4.agregarEntrada(new PatronItem("x16", 1));
            n4.agregarEntrada(new PatronItem("x17", 1));
            n4.agregarEntrada(new PatronItem("x18", 1));
            n4.agregarEntrada(new PatronItem("x19", 0));
            n4.agregarEntrada(new PatronItem("x20", 0));
            n4.agregarEntrada(new PatronItem("x21", 0));
            n4.agregarEntrada(new PatronItem("x22", 0));
            n4.agregarEntrada(new PatronItem("x23", 0));
            n4.agregarEntrada(new PatronItem("x24", 1));
            n4.agregarEntrada(new PatronItem("x25", 0));
            n4.agregarEntrada(new PatronItem("x26", 0));
            n4.agregarEntrada(new PatronItem("x27", 0));
            n4.agregarEntrada(new PatronItem("x28", 0));
            n4.agregarEntrada(new PatronItem("x29", 0));
            n4.agregarEntrada(new PatronItem("x30", 1));
            n4.agregarEntrada(new PatronItem("x31", 0));
            n4.agregarEntrada(new PatronItem("x32", 0));
            n4.agregarEntrada(new PatronItem("x33", 0));
            n4.agregarEntrada(new PatronItem("x34", 0));
            n4.agregarEntrada(new PatronItem("x35", 0));
            n4.agregarEntrada(new PatronItem("x36", 1));
            n4.agregarSalida(new PatronItem("t1", 0));
            n4.agregarSalida(new PatronItem("t2", 0));
            n4.agregarSalida(new PatronItem("t3", 0));
            n4.agregarSalida(new PatronItem("t4", 1));
            n4.agregarSalida(new PatronItem("t5", 0));
            n4.agregarSalida(new PatronItem("t6", 0));

            n5.agregarEntrada(new PatronItem("x1", 0));
            n5.agregarEntrada(new PatronItem("x2", 1));
            n5.agregarEntrada(new PatronItem("x3", 1));
            n5.agregarEntrada(new PatronItem("x4", 1));
            n5.agregarEntrada(new PatronItem("x5", 1));
            n5.agregarEntrada(new PatronItem("x6", 0));
            n5.agregarEntrada(new PatronItem("x7", 0));
            n5.agregarEntrada(new PatronItem("x8", 1));
            n5.agregarEntrada(new PatronItem("x9", 0));
            n5.agregarEntrada(new PatronItem("x10", 0));
            n5.agregarEntrada(new PatronItem("x11", 0));
            n5.agregarEntrada(new PatronItem("x12", 0));
            n5.agregarEntrada(new PatronItem("x13", 0));
            n5.agregarEntrada(new PatronItem("x14", 1));
            n5.agregarEntrada(new PatronItem("x15", 1));
            n5.agregarEntrada(new PatronItem("x16", 1));
            n5.agregarEntrada(new PatronItem("x17", 0));
            n5.agregarEntrada(new PatronItem("x18", 0));
            n5.agregarEntrada(new PatronItem("x19", 0));
            n5.agregarEntrada(new PatronItem("x20", 0));
            n5.agregarEntrada(new PatronItem("x21", 0));
            n5.agregarEntrada(new PatronItem("x22", 0));
            n5.agregarEntrada(new PatronItem("x23", 1));
            n5.agregarEntrada(new PatronItem("x24", 0));
            n5.agregarEntrada(new PatronItem("x25", 0));
            n5.agregarEntrada(new PatronItem("x26", 0));
            n5.agregarEntrada(new PatronItem("x27", 0));
            n5.agregarEntrada(new PatronItem("x28", 0));
            n5.agregarEntrada(new PatronItem("x29", 1));
            n5.agregarEntrada(new PatronItem("x30", 0));
            n5.agregarEntrada(new PatronItem("x31", 0));
            n5.agregarEntrada(new PatronItem("x32", 1));
            n5.agregarEntrada(new PatronItem("x33", 1));
            n5.agregarEntrada(new PatronItem("x34", 1));
            n5.agregarEntrada(new PatronItem("x35", 0));
            n5.agregarEntrada(new PatronItem("x36", 0));
            n5.agregarSalida(new PatronItem("t1", 0));
            n5.agregarSalida(new PatronItem("t2", 0));
            n5.agregarSalida(new PatronItem("t3", 0));
            n5.agregarSalida(new PatronItem("t4", 1));
            n5.agregarSalida(new PatronItem("t5", 0));
            n5.agregarSalida(new PatronItem("t6", 1));

            n6.agregarEntrada(new PatronItem("x1", 0));
            n6.agregarEntrada(new PatronItem("x2", 0));
            n6.agregarEntrada(new PatronItem("x3", 1));
            n6.agregarEntrada(new PatronItem("x4", 1));
            n6.agregarEntrada(new PatronItem("x5", 1));
            n6.agregarEntrada(new PatronItem("x6", 0));
            n6.agregarEntrada(new PatronItem("x7", 0));
            n6.agregarEntrada(new PatronItem("x8", 1));
            n6.agregarEntrada(new PatronItem("x9", 0));
            n6.agregarEntrada(new PatronItem("x10", 0));
            n6.agregarEntrada(new PatronItem("x11", 0));
            n6.agregarEntrada(new PatronItem("x12", 0));
            n6.agregarEntrada(new PatronItem("x13", 0));
            n6.agregarEntrada(new PatronItem("x14", 1));
            n6.agregarEntrada(new PatronItem("x15", 0));
            n6.agregarEntrada(new PatronItem("x16", 0));
            n6.agregarEntrada(new PatronItem("x17", 0));
            n6.agregarEntrada(new PatronItem("x18", 0));
            n6.agregarEntrada(new PatronItem("x19", 0));
            n6.agregarEntrada(new PatronItem("x20", 1));
            n6.agregarEntrada(new PatronItem("x21", 1));
            n6.agregarEntrada(new PatronItem("x22", 1));
            n6.agregarEntrada(new PatronItem("x23", 0));
            n6.agregarEntrada(new PatronItem("x24", 0));
            n6.agregarEntrada(new PatronItem("x25", 0));
            n6.agregarEntrada(new PatronItem("x26", 1));
            n6.agregarEntrada(new PatronItem("x27", 0));
            n6.agregarEntrada(new PatronItem("x28", 0));
            n6.agregarEntrada(new PatronItem("x29", 1));
            n6.agregarEntrada(new PatronItem("x30", 0));
            n6.agregarEntrada(new PatronItem("x31", 0));
            n6.agregarEntrada(new PatronItem("x32", 0));
            n6.agregarEntrada(new PatronItem("x33", 1));
            n6.agregarEntrada(new PatronItem("x34", 1));
            n6.agregarEntrada(new PatronItem("x35", 0));
            n6.agregarEntrada(new PatronItem("x36", 0));
            n6.agregarSalida(new PatronItem("t1", 0));
            n6.agregarSalida(new PatronItem("t2", 0));
            n6.agregarSalida(new PatronItem("t3", 0));
            n6.agregarSalida(new PatronItem("t4", 1));
            n6.agregarSalida(new PatronItem("t5", 1));
            n6.agregarSalida(new PatronItem("t6", 0));

            n7.agregarEntrada(new PatronItem("x1", 1));
            n7.agregarEntrada(new PatronItem("x2", 1));
            n7.agregarEntrada(new PatronItem("x3", 1));
            n7.agregarEntrada(new PatronItem("x4", 1));
            n7.agregarEntrada(new PatronItem("x5", 1));
            n7.agregarEntrada(new PatronItem("x6", 1));
            n7.agregarEntrada(new PatronItem("x7", 0));
            n7.agregarEntrada(new PatronItem("x8", 0));
            n7.agregarEntrada(new PatronItem("x9", 0));
            n7.agregarEntrada(new PatronItem("x10", 0));
            n7.agregarEntrada(new PatronItem("x11", 0));
            n7.agregarEntrada(new PatronItem("x12", 1));
            n7.agregarEntrada(new PatronItem("x13", 0));
            n7.agregarEntrada(new PatronItem("x14", 0));
            n7.agregarEntrada(new PatronItem("x15", 0));
            n7.agregarEntrada(new PatronItem("x16", 0));
            n7.agregarEntrada(new PatronItem("x17", 1));
            n7.agregarEntrada(new PatronItem("x18", 0));
            n7.agregarEntrada(new PatronItem("x19", 0));
            n7.agregarEntrada(new PatronItem("x20", 0));
            n7.agregarEntrada(new PatronItem("x21", 0));
            n7.agregarEntrada(new PatronItem("x22", 1));
            n7.agregarEntrada(new PatronItem("x23", 0));
            n7.agregarEntrada(new PatronItem("x24", 0));
            n7.agregarEntrada(new PatronItem("x25", 0));
            n7.agregarEntrada(new PatronItem("x26", 0));
            n7.agregarEntrada(new PatronItem("x27", 1));
            n7.agregarEntrada(new PatronItem("x28", 0));
            n7.agregarEntrada(new PatronItem("x29", 0));
            n7.agregarEntrada(new PatronItem("x30", 0));
            n7.agregarEntrada(new PatronItem("x31", 0));
            n7.agregarEntrada(new PatronItem("x32", 1));
            n7.agregarEntrada(new PatronItem("x33", 0));
            n7.agregarEntrada(new PatronItem("x34", 0));
            n7.agregarEntrada(new PatronItem("x35", 0));
            n7.agregarEntrada(new PatronItem("x36", 0));
            n7.agregarSalida(new PatronItem("t1", 0));
            n7.agregarSalida(new PatronItem("t2", 0));
            n7.agregarSalida(new PatronItem("t3", 0));
            n7.agregarSalida(new PatronItem("t4", 1));
            n7.agregarSalida(new PatronItem("t5", 1));
            n7.agregarSalida(new PatronItem("t6", 1));

            n8.agregarEntrada(new PatronItem("x1", 0));
            n8.agregarEntrada(new PatronItem("x2", 0));
            n8.agregarEntrada(new PatronItem("x3", 1));
            n8.agregarEntrada(new PatronItem("x4", 1));
            n8.agregarEntrada(new PatronItem("x5", 0));
            n8.agregarEntrada(new PatronItem("x6", 0));
            n8.agregarEntrada(new PatronItem("x7", 0));
            n8.agregarEntrada(new PatronItem("x8", 1));
            n8.agregarEntrada(new PatronItem("x9", 0));
            n8.agregarEntrada(new PatronItem("x10", 0));
            n8.agregarEntrada(new PatronItem("x11", 1));
            n8.agregarEntrada(new PatronItem("x12", 0));
            n8.agregarEntrada(new PatronItem("x13", 0));
            n8.agregarEntrada(new PatronItem("x14", 0));
            n8.agregarEntrada(new PatronItem("x15", 1));
            n8.agregarEntrada(new PatronItem("x16", 1));
            n8.agregarEntrada(new PatronItem("x17", 0));
            n8.agregarEntrada(new PatronItem("x18", 0));
            n8.agregarEntrada(new PatronItem("x19", 0));
            n8.agregarEntrada(new PatronItem("x20", 1));
            n8.agregarEntrada(new PatronItem("x21", 0));
            n8.agregarEntrada(new PatronItem("x22", 0));
            n8.agregarEntrada(new PatronItem("x23", 1));
            n8.agregarEntrada(new PatronItem("x24", 0));
            n8.agregarEntrada(new PatronItem("x25", 0));
            n8.agregarEntrada(new PatronItem("x26", 1));
            n8.agregarEntrada(new PatronItem("x27", 0));
            n8.agregarEntrada(new PatronItem("x28", 0));
            n8.agregarEntrada(new PatronItem("x29", 1));
            n8.agregarEntrada(new PatronItem("x30", 0));
            n8.agregarEntrada(new PatronItem("x31", 0));
            n8.agregarEntrada(new PatronItem("x32", 0));
            n8.agregarEntrada(new PatronItem("x33", 1));
            n8.agregarEntrada(new PatronItem("x34", 1));
            n8.agregarEntrada(new PatronItem("x35", 0));
            n8.agregarEntrada(new PatronItem("x36", 0));
            n8.agregarSalida(new PatronItem("t1", 0));
            n8.agregarSalida(new PatronItem("t2", 0));
            n8.agregarSalida(new PatronItem("t3", 1));
            n8.agregarSalida(new PatronItem("t4", 0));
            n8.agregarSalida(new PatronItem("t5", 0));
            n8.agregarSalida(new PatronItem("t6", 0));

            n9.agregarEntrada(new PatronItem("x1", 0));
            n9.agregarEntrada(new PatronItem("x2", 0));
            n9.agregarEntrada(new PatronItem("x3", 1));
            n9.agregarEntrada(new PatronItem("x4", 1));
            n9.agregarEntrada(new PatronItem("x5", 0));
            n9.agregarEntrada(new PatronItem("x6", 0));
            n9.agregarEntrada(new PatronItem("x7", 0));
            n9.agregarEntrada(new PatronItem("x8", 1));
            n9.agregarEntrada(new PatronItem("x9", 0));
            n9.agregarEntrada(new PatronItem("x10", 0));
            n9.agregarEntrada(new PatronItem("x11", 1));
            n9.agregarEntrada(new PatronItem("x12", 0));
            n9.agregarEntrada(new PatronItem("x13", 0));
            n9.agregarEntrada(new PatronItem("x14", 0));
            n9.agregarEntrada(new PatronItem("x15", 1));
            n9.agregarEntrada(new PatronItem("x16", 1));
            n9.agregarEntrada(new PatronItem("x17", 1));
            n9.agregarEntrada(new PatronItem("x18", 0));
            n9.agregarEntrada(new PatronItem("x19", 0));
            n9.agregarEntrada(new PatronItem("x20", 0));
            n9.agregarEntrada(new PatronItem("x21", 0));
            n9.agregarEntrada(new PatronItem("x22", 0));
            n9.agregarEntrada(new PatronItem("x23", 1));
            n9.agregarEntrada(new PatronItem("x24", 0));
            n9.agregarEntrada(new PatronItem("x25", 0));
            n9.agregarEntrada(new PatronItem("x26", 0));
            n9.agregarEntrada(new PatronItem("x27", 0));
            n9.agregarEntrada(new PatronItem("x28", 0));
            n9.agregarEntrada(new PatronItem("x29", 1));
            n9.agregarEntrada(new PatronItem("x30", 0));
            n9.agregarEntrada(new PatronItem("x31", 0));
            n9.agregarEntrada(new PatronItem("x32", 0));
            n9.agregarEntrada(new PatronItem("x33", 1));
            n9.agregarEntrada(new PatronItem("x34", 1));
            n9.agregarEntrada(new PatronItem("x35", 0));
            n9.agregarEntrada(new PatronItem("x36", 0));
            n9.agregarSalida(new PatronItem("t1", 0));
            n9.agregarSalida(new PatronItem("t2", 0));
            n9.agregarSalida(new PatronItem("t3", 1));
            n9.agregarSalida(new PatronItem("t4", 0));
            n9.agregarSalida(new PatronItem("t5", 0));
            n9.agregarSalida(new PatronItem("t6", 1));

            A.agregarEntrada(new PatronItem("x1", 0));
            A.agregarEntrada(new PatronItem("x2", 0));
            A.agregarEntrada(new PatronItem("x3", 1));
            A.agregarEntrada(new PatronItem("x4", 1));
            A.agregarEntrada(new PatronItem("x5", 0));
            A.agregarEntrada(new PatronItem("x6", 0));
            A.agregarEntrada(new PatronItem("x7", 0));
            A.agregarEntrada(new PatronItem("x8", 1));
            A.agregarEntrada(new PatronItem("x9", 0));
            A.agregarEntrada(new PatronItem("x10", 0));
            A.agregarEntrada(new PatronItem("x11", 1));
            A.agregarEntrada(new PatronItem("x12", 0));
            A.agregarEntrada(new PatronItem("x13", 0));
            A.agregarEntrada(new PatronItem("x14", 1));
            A.agregarEntrada(new PatronItem("x15", 0));
            A.agregarEntrada(new PatronItem("x16", 0));
            A.agregarEntrada(new PatronItem("x17", 1));
            A.agregarEntrada(new PatronItem("x18", 0));
            A.agregarEntrada(new PatronItem("x19", 0));
            A.agregarEntrada(new PatronItem("x20", 1));
            A.agregarEntrada(new PatronItem("x21", 1));
            A.agregarEntrada(new PatronItem("x22", 1));
            A.agregarEntrada(new PatronItem("x23", 1));
            A.agregarEntrada(new PatronItem("x24", 0));
            A.agregarEntrada(new PatronItem("x25", 0));
            A.agregarEntrada(new PatronItem("x26", 1));
            A.agregarEntrada(new PatronItem("x27", 0));
            A.agregarEntrada(new PatronItem("x28", 0));
            A.agregarEntrada(new PatronItem("x29", 1));
            A.agregarEntrada(new PatronItem("x30", 0));
            A.agregarEntrada(new PatronItem("x31", 0));
            A.agregarEntrada(new PatronItem("x32", 1));
            A.agregarEntrada(new PatronItem("x33", 0));
            A.agregarEntrada(new PatronItem("x34", 0));
            A.agregarEntrada(new PatronItem("x35", 1));
            A.agregarEntrada(new PatronItem("x36", 0));
            A.agregarSalida(new PatronItem("t1", 0));
            A.agregarSalida(new PatronItem("t2", 0));
            A.agregarSalida(new PatronItem("t3", 1));
            A.agregarSalida(new PatronItem("t4", 0));
            A.agregarSalida(new PatronItem("t5", 1));
            A.agregarSalida(new PatronItem("t6", 0));

            B.agregarEntrada(new PatronItem("x1", 0));
            B.agregarEntrada(new PatronItem("x2", 1));
            B.agregarEntrada(new PatronItem("x3", 1));
            B.agregarEntrada(new PatronItem("x4", 1));
            B.agregarEntrada(new PatronItem("x5", 0));
            B.agregarEntrada(new PatronItem("x6", 0));
            B.agregarEntrada(new PatronItem("x7", 0));
            B.agregarEntrada(new PatronItem("x8", 1));
            B.agregarEntrada(new PatronItem("x9", 0));
            B.agregarEntrada(new PatronItem("x10", 0));
            B.agregarEntrada(new PatronItem("x11", 1));
            B.agregarEntrada(new PatronItem("x12", 0));
            B.agregarEntrada(new PatronItem("x13", 0));
            B.agregarEntrada(new PatronItem("x14", 1));
            B.agregarEntrada(new PatronItem("x15", 1));
            B.agregarEntrada(new PatronItem("x16", 1));
            B.agregarEntrada(new PatronItem("x17", 0));
            B.agregarEntrada(new PatronItem("x18", 0));
            B.agregarEntrada(new PatronItem("x19", 0));
            B.agregarEntrada(new PatronItem("x20", 1));
            B.agregarEntrada(new PatronItem("x21", 0));
            B.agregarEntrada(new PatronItem("x22", 0));
            B.agregarEntrada(new PatronItem("x23", 1));
            B.agregarEntrada(new PatronItem("x24", 0));
            B.agregarEntrada(new PatronItem("x25", 0));
            B.agregarEntrada(new PatronItem("x26", 1));
            B.agregarEntrada(new PatronItem("x27", 0));
            B.agregarEntrada(new PatronItem("x28", 0));
            B.agregarEntrada(new PatronItem("x29", 1));
            B.agregarEntrada(new PatronItem("x30", 0));
            B.agregarEntrada(new PatronItem("x31", 0));
            B.agregarEntrada(new PatronItem("x32", 1));
            B.agregarEntrada(new PatronItem("x33", 1));
            B.agregarEntrada(new PatronItem("x34", 1));
            B.agregarEntrada(new PatronItem("x35", 0));
            B.agregarEntrada(new PatronItem("x36", 0));
            B.agregarSalida(new PatronItem("t1", 0));
            B.agregarSalida(new PatronItem("t2", 0));
            B.agregarSalida(new PatronItem("t3", 1));
            B.agregarSalida(new PatronItem("t4", 0));
            B.agregarSalida(new PatronItem("t5", 1));
            B.agregarSalida(new PatronItem("t6", 1));

            C.agregarEntrada(new PatronItem("x1", 0));
            C.agregarEntrada(new PatronItem("x2", 0));
            C.agregarEntrada(new PatronItem("x3", 1));
            C.agregarEntrada(new PatronItem("x4", 1));
            C.agregarEntrada(new PatronItem("x5", 1));
            C.agregarEntrada(new PatronItem("x6", 0));
            C.agregarEntrada(new PatronItem("x7", 0));
            C.agregarEntrada(new PatronItem("x8", 1));
            C.agregarEntrada(new PatronItem("x9", 0));
            C.agregarEntrada(new PatronItem("x10", 0));
            C.agregarEntrada(new PatronItem("x11", 0));
            C.agregarEntrada(new PatronItem("x12", 0));
            C.agregarEntrada(new PatronItem("x13", 0));
            C.agregarEntrada(new PatronItem("x14", 1));
            C.agregarEntrada(new PatronItem("x15", 0));
            C.agregarEntrada(new PatronItem("x16", 0));
            C.agregarEntrada(new PatronItem("x17", 0));
            C.agregarEntrada(new PatronItem("x18", 0));
            C.agregarEntrada(new PatronItem("x19", 0));
            C.agregarEntrada(new PatronItem("x20", 1));
            C.agregarEntrada(new PatronItem("x21", 0));
            C.agregarEntrada(new PatronItem("x22", 0));
            C.agregarEntrada(new PatronItem("x23", 0));
            C.agregarEntrada(new PatronItem("x24", 0));
            C.agregarEntrada(new PatronItem("x25", 0));
            C.agregarEntrada(new PatronItem("x26", 1));
            C.agregarEntrada(new PatronItem("x27", 0));
            C.agregarEntrada(new PatronItem("x28", 0));
            C.agregarEntrada(new PatronItem("x29", 0));
            C.agregarEntrada(new PatronItem("x30", 0));
            C.agregarEntrada(new PatronItem("x31", 0));
            C.agregarEntrada(new PatronItem("x32", 0));
            C.agregarEntrada(new PatronItem("x33", 1));
            C.agregarEntrada(new PatronItem("x34", 1));
            C.agregarEntrada(new PatronItem("x35", 1));
            C.agregarEntrada(new PatronItem("x36", 0));
            C.agregarSalida(new PatronItem("t1", 0));
            C.agregarSalida(new PatronItem("t2", 0));
            C.agregarSalida(new PatronItem("t3", 1));
            C.agregarSalida(new PatronItem("t4", 1));
            C.agregarSalida(new PatronItem("t5", 0));
            C.agregarSalida(new PatronItem("t6", 0));

            D.agregarEntrada(new PatronItem("x1", 0));
            D.agregarEntrada(new PatronItem("x2", 1));
            D.agregarEntrada(new PatronItem("x3", 1));
            D.agregarEntrada(new PatronItem("x4", 1));
            D.agregarEntrada(new PatronItem("x5", 0));
            D.agregarEntrada(new PatronItem("x6", 0));
            D.agregarEntrada(new PatronItem("x7", 0));
            D.agregarEntrada(new PatronItem("x8", 1));
            D.agregarEntrada(new PatronItem("x9", 0));
            D.agregarEntrada(new PatronItem("x10", 0));
            D.agregarEntrada(new PatronItem("x11", 1));
            D.agregarEntrada(new PatronItem("x12", 0));
            D.agregarEntrada(new PatronItem("x13", 0));
            D.agregarEntrada(new PatronItem("x14", 1));
            D.agregarEntrada(new PatronItem("x15", 0));
            D.agregarEntrada(new PatronItem("x16", 0));
            D.agregarEntrada(new PatronItem("x17", 1));
            D.agregarEntrada(new PatronItem("x18", 0));
            D.agregarEntrada(new PatronItem("x19", 0));
            D.agregarEntrada(new PatronItem("x20", 1));
            D.agregarEntrada(new PatronItem("x21", 0));
            D.agregarEntrada(new PatronItem("x22", 0));
            D.agregarEntrada(new PatronItem("x23", 1));
            D.agregarEntrada(new PatronItem("x24", 0));
            D.agregarEntrada(new PatronItem("x25", 0));
            D.agregarEntrada(new PatronItem("x26", 1));
            D.agregarEntrada(new PatronItem("x27", 0));
            D.agregarEntrada(new PatronItem("x28", 0));
            D.agregarEntrada(new PatronItem("x29", 1));
            D.agregarEntrada(new PatronItem("x30", 0));
            D.agregarEntrada(new PatronItem("x31", 0));
            D.agregarEntrada(new PatronItem("x32", 1));
            D.agregarEntrada(new PatronItem("x33", 1));
            D.agregarEntrada(new PatronItem("x34", 1));
            D.agregarEntrada(new PatronItem("x35", 0));
            D.agregarEntrada(new PatronItem("x36", 0));
            D.agregarSalida(new PatronItem("t1", 0));
            D.agregarSalida(new PatronItem("t2", 0));
            D.agregarSalida(new PatronItem("t3", 1));
            D.agregarSalida(new PatronItem("t4", 1));
            D.agregarSalida(new PatronItem("t5", 0));
            D.agregarSalida(new PatronItem("t6", 1));

            E.agregarEntrada(new PatronItem("x1", 0));
            E.agregarEntrada(new PatronItem("x2", 1));
            E.agregarEntrada(new PatronItem("x3", 1));
            E.agregarEntrada(new PatronItem("x4", 1));
            E.agregarEntrada(new PatronItem("x5", 1));
            E.agregarEntrada(new PatronItem("x6", 0));
            E.agregarEntrada(new PatronItem("x7", 0));
            E.agregarEntrada(new PatronItem("x8", 1));
            E.agregarEntrada(new PatronItem("x9", 0));
            E.agregarEntrada(new PatronItem("x10", 0));
            E.agregarEntrada(new PatronItem("x11", 0));
            E.agregarEntrada(new PatronItem("x12", 0));
            E.agregarEntrada(new PatronItem("x13", 0));
            E.agregarEntrada(new PatronItem("x14", 1));
            E.agregarEntrada(new PatronItem("x15", 1));
            E.agregarEntrada(new PatronItem("x16", 1));
            E.agregarEntrada(new PatronItem("x17", 1));
            E.agregarEntrada(new PatronItem("x18", 0));
            E.agregarEntrada(new PatronItem("x19", 0));
            E.agregarEntrada(new PatronItem("x20", 1));
            E.agregarEntrada(new PatronItem("x21", 0));
            E.agregarEntrada(new PatronItem("x22", 0));
            E.agregarEntrada(new PatronItem("x23", 0));
            E.agregarEntrada(new PatronItem("x24", 0));
            E.agregarEntrada(new PatronItem("x25", 0));
            E.agregarEntrada(new PatronItem("x26", 1));
            E.agregarEntrada(new PatronItem("x27", 0));
            E.agregarEntrada(new PatronItem("x28", 0));
            E.agregarEntrada(new PatronItem("x29", 0));
            E.agregarEntrada(new PatronItem("x30", 0));
            E.agregarEntrada(new PatronItem("x31", 0));
            E.agregarEntrada(new PatronItem("x32", 1));
            E.agregarEntrada(new PatronItem("x33", 1));
            E.agregarEntrada(new PatronItem("x34", 1));
            E.agregarEntrada(new PatronItem("x35", 1));
            E.agregarEntrada(new PatronItem("x36", 0));
            E.agregarSalida(new PatronItem("t1", 0));
            E.agregarSalida(new PatronItem("t2", 0));
            E.agregarSalida(new PatronItem("t3", 1));
            E.agregarSalida(new PatronItem("t4", 1));
            E.agregarSalida(new PatronItem("t5", 1));
            E.agregarSalida(new PatronItem("t6", 0));

            F.agregarEntrada(new PatronItem("x1", 0));
            F.agregarEntrada(new PatronItem("x2", 1));
            F.agregarEntrada(new PatronItem("x3", 1));
            F.agregarEntrada(new PatronItem("x4", 1));
            F.agregarEntrada(new PatronItem("x5", 1));
            F.agregarEntrada(new PatronItem("x6", 0));
            F.agregarEntrada(new PatronItem("x7", 0));
            F.agregarEntrada(new PatronItem("x8", 1));
            F.agregarEntrada(new PatronItem("x9", 0));
            F.agregarEntrada(new PatronItem("x10", 0));
            F.agregarEntrada(new PatronItem("x11", 0));
            F.agregarEntrada(new PatronItem("x12", 0));
            F.agregarEntrada(new PatronItem("x13", 0));
            F.agregarEntrada(new PatronItem("x14", 1));
            F.agregarEntrada(new PatronItem("x15", 1));
            F.agregarEntrada(new PatronItem("x16", 1));
            F.agregarEntrada(new PatronItem("x17", 1));
            F.agregarEntrada(new PatronItem("x18", 0));
            F.agregarEntrada(new PatronItem("x19", 0));
            F.agregarEntrada(new PatronItem("x20", 1));
            F.agregarEntrada(new PatronItem("x21", 0));
            F.agregarEntrada(new PatronItem("x22", 0));
            F.agregarEntrada(new PatronItem("x23", 0));
            F.agregarEntrada(new PatronItem("x24", 0));
            F.agregarEntrada(new PatronItem("x25", 0));
            F.agregarEntrada(new PatronItem("x26", 1));
            F.agregarEntrada(new PatronItem("x27", 0));
            F.agregarEntrada(new PatronItem("x28", 0));
            F.agregarEntrada(new PatronItem("x29", 0));
            F.agregarEntrada(new PatronItem("x30", 0));
            F.agregarEntrada(new PatronItem("x31", 0));
            F.agregarEntrada(new PatronItem("x32", 1));
            F.agregarEntrada(new PatronItem("x33", 0));
            F.agregarEntrada(new PatronItem("x34", 0));
            F.agregarEntrada(new PatronItem("x35", 0));
            F.agregarEntrada(new PatronItem("x36", 0));
            F.agregarSalida(new PatronItem("t1", 0));
            F.agregarSalida(new PatronItem("t2", 0));
            F.agregarSalida(new PatronItem("t3", 1));
            F.agregarSalida(new PatronItem("t4", 1));
            F.agregarSalida(new PatronItem("t5", 1));
            F.agregarSalida(new PatronItem("t6", 1));

            G.agregarEntrada(new PatronItem("x1", 0));
            G.agregarEntrada(new PatronItem("x2", 1));
            G.agregarEntrada(new PatronItem("x3", 1));
            G.agregarEntrada(new PatronItem("x4", 1));
            G.agregarEntrada(new PatronItem("x5", 1));
            G.agregarEntrada(new PatronItem("x6", 1));
            G.agregarEntrada(new PatronItem("x7", 0));
            G.agregarEntrada(new PatronItem("x8", 1));
            G.agregarEntrada(new PatronItem("x9", 0));
            G.agregarEntrada(new PatronItem("x10", 0));
            G.agregarEntrada(new PatronItem("x11", 0));
            G.agregarEntrada(new PatronItem("x12", 0));
            G.agregarEntrada(new PatronItem("x13", 0));
            G.agregarEntrada(new PatronItem("x14", 1));
            G.agregarEntrada(new PatronItem("x15", 0));
            G.agregarEntrada(new PatronItem("x16", 0));
            G.agregarEntrada(new PatronItem("x17", 0));
            G.agregarEntrada(new PatronItem("x18", 0));
            G.agregarEntrada(new PatronItem("x19", 0));
            G.agregarEntrada(new PatronItem("x20", 1));
            G.agregarEntrada(new PatronItem("x21", 0));
            G.agregarEntrada(new PatronItem("x22", 1));
            G.agregarEntrada(new PatronItem("x23", 1));
            G.agregarEntrada(new PatronItem("x24", 1));
            G.agregarEntrada(new PatronItem("x25", 0));
            G.agregarEntrada(new PatronItem("x26", 1));
            G.agregarEntrada(new PatronItem("x27", 0));
            G.agregarEntrada(new PatronItem("x28", 0));
            G.agregarEntrada(new PatronItem("x29", 0));
            G.agregarEntrada(new PatronItem("x30", 1));
            G.agregarEntrada(new PatronItem("x31", 0));
            G.agregarEntrada(new PatronItem("x32", 1));
            G.agregarEntrada(new PatronItem("x33", 1));
            G.agregarEntrada(new PatronItem("x34", 1));
            G.agregarEntrada(new PatronItem("x35", 1));
            G.agregarEntrada(new PatronItem("x36", 1));
            G.agregarSalida(new PatronItem("t1", 0));
            G.agregarSalida(new PatronItem("t2", 1));
            G.agregarSalida(new PatronItem("t3", 0));
            G.agregarSalida(new PatronItem("t4", 0));
            G.agregarSalida(new PatronItem("t5", 0));
            G.agregarSalida(new PatronItem("t6", 0));

            H.agregarEntrada(new PatronItem("x1", 1));
            H.agregarEntrada(new PatronItem("x2", 1));
            H.agregarEntrada(new PatronItem("x3", 0));
            H.agregarEntrada(new PatronItem("x4", 0));
            H.agregarEntrada(new PatronItem("x5", 1));
            H.agregarEntrada(new PatronItem("x6", 1));
            H.agregarEntrada(new PatronItem("x7", 1));
            H.agregarEntrada(new PatronItem("x8", 1));
            H.agregarEntrada(new PatronItem("x9", 0));
            H.agregarEntrada(new PatronItem("x10", 0));
            H.agregarEntrada(new PatronItem("x11", 1));
            H.agregarEntrada(new PatronItem("x12", 1));
            H.agregarEntrada(new PatronItem("x13", 1));
            H.agregarEntrada(new PatronItem("x14", 1));
            H.agregarEntrada(new PatronItem("x15", 1));
            H.agregarEntrada(new PatronItem("x16", 1));
            H.agregarEntrada(new PatronItem("x17", 1));
            H.agregarEntrada(new PatronItem("x18", 1));
            H.agregarEntrada(new PatronItem("x19", 1));
            H.agregarEntrada(new PatronItem("x20", 1));
            H.agregarEntrada(new PatronItem("x21", 1));
            H.agregarEntrada(new PatronItem("x22", 1));
            H.agregarEntrada(new PatronItem("x23", 1));
            H.agregarEntrada(new PatronItem("x24", 1));
            H.agregarEntrada(new PatronItem("x25", 1));
            H.agregarEntrada(new PatronItem("x26", 1));
            H.agregarEntrada(new PatronItem("x27", 0));
            H.agregarEntrada(new PatronItem("x28", 0));
            H.agregarEntrada(new PatronItem("x29", 1));
            H.agregarEntrada(new PatronItem("x30", 1));
            H.agregarEntrada(new PatronItem("x31", 1));
            H.agregarEntrada(new PatronItem("x32", 1));
            H.agregarEntrada(new PatronItem("x33", 0));
            H.agregarEntrada(new PatronItem("x34", 0));
            H.agregarEntrada(new PatronItem("x35", 1));
            H.agregarEntrada(new PatronItem("x36", 1));
            H.agregarSalida(new PatronItem("t1", 0));
            H.agregarSalida(new PatronItem("t2", 1));
            H.agregarSalida(new PatronItem("t3", 0));
            H.agregarSalida(new PatronItem("t4", 0));
            H.agregarSalida(new PatronItem("t5", 0));
            H.agregarSalida(new PatronItem("t6", 1));

            I.agregarEntrada(new PatronItem("x1", 1));
            I.agregarEntrada(new PatronItem("x2", 1));
            I.agregarEntrada(new PatronItem("x3", 1));
            I.agregarEntrada(new PatronItem("x4", 1));
            I.agregarEntrada(new PatronItem("x5", 1));
            I.agregarEntrada(new PatronItem("x6", 1));
            I.agregarEntrada(new PatronItem("x7", 1));
            I.agregarEntrada(new PatronItem("x8", 1));
            I.agregarEntrada(new PatronItem("x9", 1));
            I.agregarEntrada(new PatronItem("x10", 1));
            I.agregarEntrada(new PatronItem("x11", 1));
            I.agregarEntrada(new PatronItem("x12", 1));
            I.agregarEntrada(new PatronItem("x13", 0));
            I.agregarEntrada(new PatronItem("x14", 0));
            I.agregarEntrada(new PatronItem("x15", 1));
            I.agregarEntrada(new PatronItem("x16", 1));
            I.agregarEntrada(new PatronItem("x17", 0));
            I.agregarEntrada(new PatronItem("x18", 0));
            I.agregarEntrada(new PatronItem("x19", 0));
            I.agregarEntrada(new PatronItem("x20", 0));
            I.agregarEntrada(new PatronItem("x21", 1));
            I.agregarEntrada(new PatronItem("x22", 1));
            I.agregarEntrada(new PatronItem("x23", 0));
            I.agregarEntrada(new PatronItem("x24", 0));
            I.agregarEntrada(new PatronItem("x25", 1));
            I.agregarEntrada(new PatronItem("x26", 1));
            I.agregarEntrada(new PatronItem("x27", 1));
            I.agregarEntrada(new PatronItem("x28", 1));
            I.agregarEntrada(new PatronItem("x29", 1));
            I.agregarEntrada(new PatronItem("x30", 1));
            I.agregarEntrada(new PatronItem("x31", 1));
            I.agregarEntrada(new PatronItem("x32", 1));
            I.agregarEntrada(new PatronItem("x33", 1));
            I.agregarEntrada(new PatronItem("x34", 1));
            I.agregarEntrada(new PatronItem("x35", 1));
            I.agregarEntrada(new PatronItem("x36", 1));
            I.agregarSalida(new PatronItem("t1", 0));
            I.agregarSalida(new PatronItem("t2", 1));
            I.agregarSalida(new PatronItem("t3", 0));
            I.agregarSalida(new PatronItem("t4", 0));
            I.agregarSalida(new PatronItem("t5", 1));
            I.agregarSalida(new PatronItem("t6", 0));

            J.agregarEntrada(new PatronItem("x1", 0));
            J.agregarEntrada(new PatronItem("x2", 1));
            J.agregarEntrada(new PatronItem("x3", 1));
            J.agregarEntrada(new PatronItem("x4", 1));
            J.agregarEntrada(new PatronItem("x5", 1));
            J.agregarEntrada(new PatronItem("x6", 1));
            J.agregarEntrada(new PatronItem("x7", 0));
            J.agregarEntrada(new PatronItem("x8", 0));
            J.agregarEntrada(new PatronItem("x9", 0));
            J.agregarEntrada(new PatronItem("x10", 1));
            J.agregarEntrada(new PatronItem("x11", 0));
            J.agregarEntrada(new PatronItem("x12", 0));
            J.agregarEntrada(new PatronItem("x13", 0));
            J.agregarEntrada(new PatronItem("x14", 0));
            J.agregarEntrada(new PatronItem("x15", 0));
            J.agregarEntrada(new PatronItem("x16", 1));
            J.agregarEntrada(new PatronItem("x17", 0));
            J.agregarEntrada(new PatronItem("x18", 0));
            J.agregarEntrada(new PatronItem("x19", 0));
            J.agregarEntrada(new PatronItem("x20", 0));
            J.agregarEntrada(new PatronItem("x21", 0));
            J.agregarEntrada(new PatronItem("x22", 1));
            J.agregarEntrada(new PatronItem("x23", 0));
            J.agregarEntrada(new PatronItem("x24", 0));
            J.agregarEntrada(new PatronItem("x25", 1));
            J.agregarEntrada(new PatronItem("x26", 0));
            J.agregarEntrada(new PatronItem("x27", 0));
            J.agregarEntrada(new PatronItem("x28", 1));
            J.agregarEntrada(new PatronItem("x29", 0));
            J.agregarEntrada(new PatronItem("x30", 0));
            J.agregarEntrada(new PatronItem("x31", 0));
            J.agregarEntrada(new PatronItem("x32", 1));
            J.agregarEntrada(new PatronItem("x33", 1));
            J.agregarEntrada(new PatronItem("x34", 1));
            J.agregarEntrada(new PatronItem("x35", 0));
            J.agregarEntrada(new PatronItem("x36", 0));
            J.agregarSalida(new PatronItem("t1", 0));
            J.agregarSalida(new PatronItem("t2", 1));
            J.agregarSalida(new PatronItem("t3", 0));
            J.agregarSalida(new PatronItem("t4", 0));
            J.agregarSalida(new PatronItem("t5", 1));
            J.agregarSalida(new PatronItem("t6", 1));

            K.agregarEntrada(new PatronItem("x1", 0));
            K.agregarEntrada(new PatronItem("x2", 1));
            K.agregarEntrada(new PatronItem("x3", 0));
            K.agregarEntrada(new PatronItem("x4", 0));
            K.agregarEntrada(new PatronItem("x5", 1));
            K.agregarEntrada(new PatronItem("x6", 0));
            K.agregarEntrada(new PatronItem("x7", 0));
            K.agregarEntrada(new PatronItem("x8", 1));
            K.agregarEntrada(new PatronItem("x9", 0));
            K.agregarEntrada(new PatronItem("x10", 1));
            K.agregarEntrada(new PatronItem("x11", 0));
            K.agregarEntrada(new PatronItem("x12", 0));
            K.agregarEntrada(new PatronItem("x13", 0));
            K.agregarEntrada(new PatronItem("x14", 1));
            K.agregarEntrada(new PatronItem("x15", 1));
            K.agregarEntrada(new PatronItem("x16", 0));
            K.agregarEntrada(new PatronItem("x17", 0));
            K.agregarEntrada(new PatronItem("x18", 0));
            K.agregarEntrada(new PatronItem("x19", 0));
            K.agregarEntrada(new PatronItem("x20", 1));
            K.agregarEntrada(new PatronItem("x21", 1));
            K.agregarEntrada(new PatronItem("x22", 0));
            K.agregarEntrada(new PatronItem("x23", 0));
            K.agregarEntrada(new PatronItem("x24", 0));
            K.agregarEntrada(new PatronItem("x25", 0));
            K.agregarEntrada(new PatronItem("x26", 1));
            K.agregarEntrada(new PatronItem("x27", 0));
            K.agregarEntrada(new PatronItem("x28", 1));
            K.agregarEntrada(new PatronItem("x29", 0));
            K.agregarEntrada(new PatronItem("x30", 0));
            K.agregarEntrada(new PatronItem("x31", 0));
            K.agregarEntrada(new PatronItem("x32", 1));
            K.agregarEntrada(new PatronItem("x33", 0));
            K.agregarEntrada(new PatronItem("x34", 0));
            K.agregarEntrada(new PatronItem("x35", 1));
            K.agregarEntrada(new PatronItem("x36", 0));
            K.agregarSalida(new PatronItem("t1", 0));
            K.agregarSalida(new PatronItem("t2", 1));
            K.agregarSalida(new PatronItem("t3", 0));
            K.agregarSalida(new PatronItem("t4", 1));
            K.agregarSalida(new PatronItem("t5", 0));
            K.agregarSalida(new PatronItem("t6", 0));

            L.agregarEntrada(new PatronItem("x1", 1));
            L.agregarEntrada(new PatronItem("x2", 0));
            L.agregarEntrada(new PatronItem("x3", 0));
            L.agregarEntrada(new PatronItem("x4", 0));
            L.agregarEntrada(new PatronItem("x5", 0));
            L.agregarEntrada(new PatronItem("x6", 0));
            L.agregarEntrada(new PatronItem("x7", 1));
            L.agregarEntrada(new PatronItem("x8", 0));
            L.agregarEntrada(new PatronItem("x9", 0));
            L.agregarEntrada(new PatronItem("x10", 0));
            L.agregarEntrada(new PatronItem("x11", 0));
            L.agregarEntrada(new PatronItem("x12", 0));
            L.agregarEntrada(new PatronItem("x13", 1));
            L.agregarEntrada(new PatronItem("x14", 0));
            L.agregarEntrada(new PatronItem("x15", 0));
            L.agregarEntrada(new PatronItem("x16", 0));
            L.agregarEntrada(new PatronItem("x17", 0));
            L.agregarEntrada(new PatronItem("x18", 0));
            L.agregarEntrada(new PatronItem("x19", 1));
            L.agregarEntrada(new PatronItem("x20", 0));
            L.agregarEntrada(new PatronItem("x21", 0));
            L.agregarEntrada(new PatronItem("x22", 0));
            L.agregarEntrada(new PatronItem("x23", 0));
            L.agregarEntrada(new PatronItem("x24", 0));
            L.agregarEntrada(new PatronItem("x25", 1));
            L.agregarEntrada(new PatronItem("x26", 0));
            L.agregarEntrada(new PatronItem("x27", 0));
            L.agregarEntrada(new PatronItem("x28", 0));
            L.agregarEntrada(new PatronItem("x29", 0));
            L.agregarEntrada(new PatronItem("x30", 0));
            L.agregarEntrada(new PatronItem("x31", 1));
            L.agregarEntrada(new PatronItem("x32", 1));
            L.agregarEntrada(new PatronItem("x33", 1));
            L.agregarEntrada(new PatronItem("x34", 1));
            L.agregarEntrada(new PatronItem("x35", 1));
            L.agregarEntrada(new PatronItem("x36", 0));
            L.agregarSalida(new PatronItem("t1", 0));
            L.agregarSalida(new PatronItem("t2", 1));
            L.agregarSalida(new PatronItem("t3", 0));
            L.agregarSalida(new PatronItem("t4", 1));
            L.agregarSalida(new PatronItem("t5", 0));
            L.agregarSalida(new PatronItem("t6", 1));

            M.agregarEntrada(new PatronItem("x1", 1));
            M.agregarEntrada(new PatronItem("x2", 0));
            M.agregarEntrada(new PatronItem("x3", 0));
            M.agregarEntrada(new PatronItem("x4", 0));
            M.agregarEntrada(new PatronItem("x5", 0));
            M.agregarEntrada(new PatronItem("x6", 1));
            M.agregarEntrada(new PatronItem("x7", 1));
            M.agregarEntrada(new PatronItem("x8", 1));
            M.agregarEntrada(new PatronItem("x9", 0));
            M.agregarEntrada(new PatronItem("x10", 0));
            M.agregarEntrada(new PatronItem("x11", 1));
            M.agregarEntrada(new PatronItem("x12", 1));
            M.agregarEntrada(new PatronItem("x13", 1));
            M.agregarEntrada(new PatronItem("x14", 0));
            M.agregarEntrada(new PatronItem("x15", 1));
            M.agregarEntrada(new PatronItem("x16", 1));
            M.agregarEntrada(new PatronItem("x17", 0));
            M.agregarEntrada(new PatronItem("x18", 1));
            M.agregarEntrada(new PatronItem("x19", 1));
            M.agregarEntrada(new PatronItem("x20", 0));
            M.agregarEntrada(new PatronItem("x21", 0));
            M.agregarEntrada(new PatronItem("x22", 0));
            M.agregarEntrada(new PatronItem("x23", 0));
            M.agregarEntrada(new PatronItem("x24", 1));
            M.agregarEntrada(new PatronItem("x25", 1));
            M.agregarEntrada(new PatronItem("x26", 0));
            M.agregarEntrada(new PatronItem("x27", 0));
            M.agregarEntrada(new PatronItem("x28", 0));
            M.agregarEntrada(new PatronItem("x29", 0));
            M.agregarEntrada(new PatronItem("x30", 1));
            M.agregarEntrada(new PatronItem("x31", 1));
            M.agregarEntrada(new PatronItem("x32", 0));
            M.agregarEntrada(new PatronItem("x33", 0));
            M.agregarEntrada(new PatronItem("x34", 0));
            M.agregarEntrada(new PatronItem("x35", 0));
            M.agregarEntrada(new PatronItem("x36", 1));
            M.agregarSalida(new PatronItem("t1", 0));
            M.agregarSalida(new PatronItem("t2", 1));
            M.agregarSalida(new PatronItem("t3", 0));
            M.agregarSalida(new PatronItem("t4", 1));
            M.agregarSalida(new PatronItem("t5", 1));
            M.agregarSalida(new PatronItem("t6", 0));

            N.agregarEntrada(new PatronItem("x1", 1));
            N.agregarEntrada(new PatronItem("x2", 0));
            N.agregarEntrada(new PatronItem("x3", 0));
            N.agregarEntrada(new PatronItem("x4", 0));
            N.agregarEntrada(new PatronItem("x5", 0));
            N.agregarEntrada(new PatronItem("x6", 1));
            N.agregarEntrada(new PatronItem("x7", 1));
            N.agregarEntrada(new PatronItem("x8", 1));
            N.agregarEntrada(new PatronItem("x9", 0));
            N.agregarEntrada(new PatronItem("x10", 0));
            N.agregarEntrada(new PatronItem("x11", 0));
            N.agregarEntrada(new PatronItem("x12", 1));
            N.agregarEntrada(new PatronItem("x13", 1));
            N.agregarEntrada(new PatronItem("x14", 0));
            N.agregarEntrada(new PatronItem("x15", 1));
            N.agregarEntrada(new PatronItem("x16", 0));
            N.agregarEntrada(new PatronItem("x17", 0));
            N.agregarEntrada(new PatronItem("x18", 1));
            N.agregarEntrada(new PatronItem("x19", 1));
            N.agregarEntrada(new PatronItem("x20", 0));
            N.agregarEntrada(new PatronItem("x21", 0));
            N.agregarEntrada(new PatronItem("x22", 1));
            N.agregarEntrada(new PatronItem("x23", 0));
            N.agregarEntrada(new PatronItem("x24", 1));
            N.agregarEntrada(new PatronItem("x25", 1));
            N.agregarEntrada(new PatronItem("x26", 0));
            N.agregarEntrada(new PatronItem("x27", 0));
            N.agregarEntrada(new PatronItem("x28", 0));
            N.agregarEntrada(new PatronItem("x29", 1));
            N.agregarEntrada(new PatronItem("x30", 1));
            N.agregarEntrada(new PatronItem("x31", 1));
            N.agregarEntrada(new PatronItem("x32", 0));
            N.agregarEntrada(new PatronItem("x33", 0));
            N.agregarEntrada(new PatronItem("x34", 0));
            N.agregarEntrada(new PatronItem("x35", 0));
            N.agregarEntrada(new PatronItem("x36", 1));
            N.agregarSalida(new PatronItem("t1", 0));
            N.agregarSalida(new PatronItem("t2", 1));
            N.agregarSalida(new PatronItem("t3", 0));
            N.agregarSalida(new PatronItem("t4", 1));
            N.agregarSalida(new PatronItem("t5", 1));
            N.agregarSalida(new PatronItem("t6", 1));

            O.agregarEntrada(new PatronItem("x1", 0));
            O.agregarEntrada(new PatronItem("x2", 1));
            O.agregarEntrada(new PatronItem("x3", 1));
            O.agregarEntrada(new PatronItem("x4", 1));
            O.agregarEntrada(new PatronItem("x5", 1));
            O.agregarEntrada(new PatronItem("x6", 0));
            O.agregarEntrada(new PatronItem("x7", 1));
            O.agregarEntrada(new PatronItem("x8", 0));
            O.agregarEntrada(new PatronItem("x9", 0));
            O.agregarEntrada(new PatronItem("x10", 0));
            O.agregarEntrada(new PatronItem("x11", 0));
            O.agregarEntrada(new PatronItem("x12", 1));
            O.agregarEntrada(new PatronItem("x13", 1));
            O.agregarEntrada(new PatronItem("x14", 0));
            O.agregarEntrada(new PatronItem("x15", 0));
            O.agregarEntrada(new PatronItem("x16", 0));
            O.agregarEntrada(new PatronItem("x17", 0));
            O.agregarEntrada(new PatronItem("x18", 1));
            O.agregarEntrada(new PatronItem("x19", 1));
            O.agregarEntrada(new PatronItem("x20", 0));
            O.agregarEntrada(new PatronItem("x21", 0));
            O.agregarEntrada(new PatronItem("x22", 0));
            O.agregarEntrada(new PatronItem("x23", 0));
            O.agregarEntrada(new PatronItem("x24", 1));
            O.agregarEntrada(new PatronItem("x25", 1));
            O.agregarEntrada(new PatronItem("x26", 0));
            O.agregarEntrada(new PatronItem("x27", 0));
            O.agregarEntrada(new PatronItem("x28", 0));
            O.agregarEntrada(new PatronItem("x29", 0));
            O.agregarEntrada(new PatronItem("x30", 1));
            O.agregarEntrada(new PatronItem("x31", 0));
            O.agregarEntrada(new PatronItem("x32", 1));
            O.agregarEntrada(new PatronItem("x33", 1));
            O.agregarEntrada(new PatronItem("x34", 1));
            O.agregarEntrada(new PatronItem("x35", 1));
            O.agregarEntrada(new PatronItem("x36", 0));
            O.agregarSalida(new PatronItem("t1", 0));
            O.agregarSalida(new PatronItem("t2", 1));
            O.agregarSalida(new PatronItem("t3", 1));
            O.agregarSalida(new PatronItem("t4", 0));
            O.agregarSalida(new PatronItem("t5", 0));
            O.agregarSalida(new PatronItem("t6", 0));

            P.agregarEntrada(new PatronItem("x1", 1));
            P.agregarEntrada(new PatronItem("x2", 1));
            P.agregarEntrada(new PatronItem("x3", 1));
            P.agregarEntrada(new PatronItem("x4", 1));
            P.agregarEntrada(new PatronItem("x5", 0));
            P.agregarEntrada(new PatronItem("x6", 0));
            P.agregarEntrada(new PatronItem("x7", 1));
            P.agregarEntrada(new PatronItem("x8", 0));
            P.agregarEntrada(new PatronItem("x9", 0));
            P.agregarEntrada(new PatronItem("x10", 0));
            P.agregarEntrada(new PatronItem("x11", 1));
            P.agregarEntrada(new PatronItem("x12", 0));
            P.agregarEntrada(new PatronItem("x13", 1));
            P.agregarEntrada(new PatronItem("x14", 0));
            P.agregarEntrada(new PatronItem("x15", 0));
            P.agregarEntrada(new PatronItem("x16", 0));
            P.agregarEntrada(new PatronItem("x17", 1));
            P.agregarEntrada(new PatronItem("x18", 0));
            P.agregarEntrada(new PatronItem("x19", 1));
            P.agregarEntrada(new PatronItem("x20", 1));
            P.agregarEntrada(new PatronItem("x21", 1));
            P.agregarEntrada(new PatronItem("x22", 1));
            P.agregarEntrada(new PatronItem("x23", 0));
            P.agregarEntrada(new PatronItem("x24", 0));
            P.agregarEntrada(new PatronItem("x25", 1));
            P.agregarEntrada(new PatronItem("x26", 0));
            P.agregarEntrada(new PatronItem("x27", 0));
            P.agregarEntrada(new PatronItem("x28", 0));
            P.agregarEntrada(new PatronItem("x29", 0));
            P.agregarEntrada(new PatronItem("x30", 0));
            P.agregarEntrada(new PatronItem("x31", 1));
            P.agregarEntrada(new PatronItem("x32", 0));
            P.agregarEntrada(new PatronItem("x33", 0));
            P.agregarEntrada(new PatronItem("x34", 0));
            P.agregarEntrada(new PatronItem("x35", 0));
            P.agregarEntrada(new PatronItem("x36", 0));
            P.agregarSalida(new PatronItem("t1", 0));
            P.agregarSalida(new PatronItem("t2", 1));
            P.agregarSalida(new PatronItem("t3", 1));
            P.agregarSalida(new PatronItem("t4", 0));
            P.agregarSalida(new PatronItem("t5", 0));
            P.agregarSalida(new PatronItem("t6", 1));

            Q.agregarEntrada(new PatronItem("x1", 0));
            Q.agregarEntrada(new PatronItem("x2", 1));
            Q.agregarEntrada(new PatronItem("x3", 1));
            Q.agregarEntrada(new PatronItem("x4", 1));
            Q.agregarEntrada(new PatronItem("x5", 1));
            Q.agregarEntrada(new PatronItem("x6", 0));
            Q.agregarEntrada(new PatronItem("x7", 1));
            Q.agregarEntrada(new PatronItem("x8", 0));
            Q.agregarEntrada(new PatronItem("x9", 0));
            Q.agregarEntrada(new PatronItem("x10", 0));
            Q.agregarEntrada(new PatronItem("x11", 0));
            Q.agregarEntrada(new PatronItem("x12", 1));
            Q.agregarEntrada(new PatronItem("x13", 1));
            Q.agregarEntrada(new PatronItem("x14", 0));
            Q.agregarEntrada(new PatronItem("x15", 0));
            Q.agregarEntrada(new PatronItem("x16", 0));
            Q.agregarEntrada(new PatronItem("x17", 0));
            Q.agregarEntrada(new PatronItem("x18", 1));
            Q.agregarEntrada(new PatronItem("x19", 1));
            Q.agregarEntrada(new PatronItem("x20", 0));
            Q.agregarEntrada(new PatronItem("x21", 0));
            Q.agregarEntrada(new PatronItem("x22", 1));
            Q.agregarEntrada(new PatronItem("x23", 0));
            Q.agregarEntrada(new PatronItem("x24", 1));
            Q.agregarEntrada(new PatronItem("x25", 0));
            Q.agregarEntrada(new PatronItem("x26", 1));
            Q.agregarEntrada(new PatronItem("x27", 1));
            Q.agregarEntrada(new PatronItem("x28", 1));
            Q.agregarEntrada(new PatronItem("x29", 1));
            Q.agregarEntrada(new PatronItem("x30", 0));
            Q.agregarEntrada(new PatronItem("x31", 0));
            Q.agregarEntrada(new PatronItem("x32", 0));
            Q.agregarEntrada(new PatronItem("x33", 0));
            Q.agregarEntrada(new PatronItem("x34", 0));
            Q.agregarEntrada(new PatronItem("x35", 0));
            Q.agregarEntrada(new PatronItem("x36", 1));
            Q.agregarSalida(new PatronItem("t1", 0));
            Q.agregarSalida(new PatronItem("t2", 1));
            Q.agregarSalida(new PatronItem("t3", 1));
            Q.agregarSalida(new PatronItem("t4", 0));
            Q.agregarSalida(new PatronItem("t5", 1));
            Q.agregarSalida(new PatronItem("t6", 0));

            R.agregarEntrada(new PatronItem("x1", 1));
            R.agregarEntrada(new PatronItem("x2", 1));
            R.agregarEntrada(new PatronItem("x3", 1));
            R.agregarEntrada(new PatronItem("x4", 1));
            R.agregarEntrada(new PatronItem("x5", 0));
            R.agregarEntrada(new PatronItem("x6", 0));
            R.agregarEntrada(new PatronItem("x7", 1));
            R.agregarEntrada(new PatronItem("x8", 0));
            R.agregarEntrada(new PatronItem("x9", 0));
            R.agregarEntrada(new PatronItem("x10", 0));
            R.agregarEntrada(new PatronItem("x11", 1));
            R.agregarEntrada(new PatronItem("x12", 0));
            R.agregarEntrada(new PatronItem("x13", 1));
            R.agregarEntrada(new PatronItem("x14", 1));
            R.agregarEntrada(new PatronItem("x15", 1));
            R.agregarEntrada(new PatronItem("x16", 1));
            R.agregarEntrada(new PatronItem("x17", 0));
            R.agregarEntrada(new PatronItem("x18", 0));
            R.agregarEntrada(new PatronItem("x19", 1));
            R.agregarEntrada(new PatronItem("x20", 0));
            R.agregarEntrada(new PatronItem("x21", 1));
            R.agregarEntrada(new PatronItem("x22", 0));
            R.agregarEntrada(new PatronItem("x23", 0));
            R.agregarEntrada(new PatronItem("x24", 0));
            R.agregarEntrada(new PatronItem("x25", 1));
            R.agregarEntrada(new PatronItem("x26", 0));
            R.agregarEntrada(new PatronItem("x27", 0));
            R.agregarEntrada(new PatronItem("x28", 1));
            R.agregarEntrada(new PatronItem("x29", 0));
            R.agregarEntrada(new PatronItem("x30", 0));
            R.agregarEntrada(new PatronItem("x31", 1));
            R.agregarEntrada(new PatronItem("x32", 0));
            R.agregarEntrada(new PatronItem("x33", 0));
            R.agregarEntrada(new PatronItem("x34", 0));
            R.agregarEntrada(new PatronItem("x35", 1));
            R.agregarEntrada(new PatronItem("x36", 0));
            R.agregarSalida(new PatronItem("t1", 0));
            R.agregarSalida(new PatronItem("t2", 1));
            R.agregarSalida(new PatronItem("t3", 1));
            R.agregarSalida(new PatronItem("t4", 0));
            R.agregarSalida(new PatronItem("t5", 1));
            R.agregarSalida(new PatronItem("t6", 1));

            S.agregarEntrada(new PatronItem("x1", 0));
            S.agregarEntrada(new PatronItem("x2", 1));
            S.agregarEntrada(new PatronItem("x3", 1));
            S.agregarEntrada(new PatronItem("x4", 1));
            S.agregarEntrada(new PatronItem("x5", 1));
            S.agregarEntrada(new PatronItem("x6", 0));
            S.agregarEntrada(new PatronItem("x7", 1));
            S.agregarEntrada(new PatronItem("x8", 0));
            S.agregarEntrada(new PatronItem("x9", 0));
            S.agregarEntrada(new PatronItem("x10", 0));
            S.agregarEntrada(new PatronItem("x11", 0));
            S.agregarEntrada(new PatronItem("x12", 0));
            S.agregarEntrada(new PatronItem("x13", 0));
            S.agregarEntrada(new PatronItem("x14", 1));
            S.agregarEntrada(new PatronItem("x15", 1));
            S.agregarEntrada(new PatronItem("x16", 1));
            S.agregarEntrada(new PatronItem("x17", 0));
            S.agregarEntrada(new PatronItem("x18", 0));
            S.agregarEntrada(new PatronItem("x19", 0));
            S.agregarEntrada(new PatronItem("x20", 0));
            S.agregarEntrada(new PatronItem("x21", 0));
            S.agregarEntrada(new PatronItem("x22", 0));
            S.agregarEntrada(new PatronItem("x23", 1));
            S.agregarEntrada(new PatronItem("x24", 0));
            S.agregarEntrada(new PatronItem("x25", 0));
            S.agregarEntrada(new PatronItem("x26", 0));
            S.agregarEntrada(new PatronItem("x27", 0));
            S.agregarEntrada(new PatronItem("x28", 0));
            S.agregarEntrada(new PatronItem("x29", 1));
            S.agregarEntrada(new PatronItem("x30", 0));
            S.agregarEntrada(new PatronItem("x31", 0));
            S.agregarEntrada(new PatronItem("x32", 1));
            S.agregarEntrada(new PatronItem("x33", 1));
            S.agregarEntrada(new PatronItem("x34", 1));
            S.agregarEntrada(new PatronItem("x35", 0));
            S.agregarEntrada(new PatronItem("x36", 0));
            S.agregarSalida(new PatronItem("t1", 0));
            S.agregarSalida(new PatronItem("t2", 1));
            S.agregarSalida(new PatronItem("t3", 1));
            S.agregarSalida(new PatronItem("t4", 1));
            S.agregarSalida(new PatronItem("t5", 0));
            S.agregarSalida(new PatronItem("t6", 0));

            T.agregarEntrada(new PatronItem("x1", 1));
            T.agregarEntrada(new PatronItem("x2", 1));
            T.agregarEntrada(new PatronItem("x3", 1));
            T.agregarEntrada(new PatronItem("x4", 1));
            T.agregarEntrada(new PatronItem("x5", 1));
            T.agregarEntrada(new PatronItem("x6", 1));
            T.agregarEntrada(new PatronItem("x7", 1));
            T.agregarEntrada(new PatronItem("x8", 1));
            T.agregarEntrada(new PatronItem("x9", 1));
            T.agregarEntrada(new PatronItem("x10", 1));
            T.agregarEntrada(new PatronItem("x11", 1));
            T.agregarEntrada(new PatronItem("x12", 1));
            T.agregarEntrada(new PatronItem("x13", 0));
            T.agregarEntrada(new PatronItem("x14", 0));
            T.agregarEntrada(new PatronItem("x15", 1));
            T.agregarEntrada(new PatronItem("x16", 1));
            T.agregarEntrada(new PatronItem("x17", 0));
            T.agregarEntrada(new PatronItem("x18", 0));
            T.agregarEntrada(new PatronItem("x19", 0));
            T.agregarEntrada(new PatronItem("x20", 0));
            T.agregarEntrada(new PatronItem("x21", 1));
            T.agregarEntrada(new PatronItem("x22", 1));
            T.agregarEntrada(new PatronItem("x23", 0));
            T.agregarEntrada(new PatronItem("x24", 0));
            T.agregarEntrada(new PatronItem("x25", 0));
            T.agregarEntrada(new PatronItem("x26", 0));
            T.agregarEntrada(new PatronItem("x27", 1));
            T.agregarEntrada(new PatronItem("x28", 1));
            T.agregarEntrada(new PatronItem("x29", 0));
            T.agregarEntrada(new PatronItem("x30", 0));
            T.agregarEntrada(new PatronItem("x31", 0));
            T.agregarEntrada(new PatronItem("x32", 0));
            T.agregarEntrada(new PatronItem("x33", 1));
            T.agregarEntrada(new PatronItem("x34", 1));
            T.agregarEntrada(new PatronItem("x35", 0));
            T.agregarEntrada(new PatronItem("x36", 0));
            T.agregarSalida(new PatronItem("t1", 0));
            T.agregarSalida(new PatronItem("t2", 1));
            T.agregarSalida(new PatronItem("t3", 1));
            T.agregarSalida(new PatronItem("t4", 1));
            T.agregarSalida(new PatronItem("t5", 0));
            T.agregarSalida(new PatronItem("t6", 1));

            U.agregarEntrada(new PatronItem("x1", 1));
            U.agregarEntrada(new PatronItem("x2", 0));
            U.agregarEntrada(new PatronItem("x3", 0));
            U.agregarEntrada(new PatronItem("x4", 0));
            U.agregarEntrada(new PatronItem("x5", 0));
            U.agregarEntrada(new PatronItem("x6", 1));
            U.agregarEntrada(new PatronItem("x7", 1));
            U.agregarEntrada(new PatronItem("x8", 0));
            U.agregarEntrada(new PatronItem("x9", 0));
            U.agregarEntrada(new PatronItem("x10", 0));
            U.agregarEntrada(new PatronItem("x11", 0));
            U.agregarEntrada(new PatronItem("x12", 1));
            U.agregarEntrada(new PatronItem("x13", 1));
            U.agregarEntrada(new PatronItem("x14", 0));
            U.agregarEntrada(new PatronItem("x15", 0));
            U.agregarEntrada(new PatronItem("x16", 0));
            U.agregarEntrada(new PatronItem("x17", 0));
            U.agregarEntrada(new PatronItem("x18", 1));
            U.agregarEntrada(new PatronItem("x19", 1));
            U.agregarEntrada(new PatronItem("x20", 0));
            U.agregarEntrada(new PatronItem("x21", 0));
            U.agregarEntrada(new PatronItem("x22", 0));
            U.agregarEntrada(new PatronItem("x23", 0));
            U.agregarEntrada(new PatronItem("x24", 1));
            U.agregarEntrada(new PatronItem("x25", 1));
            U.agregarEntrada(new PatronItem("x26", 0));
            U.agregarEntrada(new PatronItem("x27", 0));
            U.agregarEntrada(new PatronItem("x28", 0));
            U.agregarEntrada(new PatronItem("x29", 0));
            U.agregarEntrada(new PatronItem("x30", 1));
            U.agregarEntrada(new PatronItem("x31", 0));
            U.agregarEntrada(new PatronItem("x32", 1));
            U.agregarEntrada(new PatronItem("x33", 1));
            U.agregarEntrada(new PatronItem("x34", 1));
            U.agregarEntrada(new PatronItem("x35", 1));
            U.agregarEntrada(new PatronItem("x36", 0));
            U.agregarSalida(new PatronItem("t1", 0));
            U.agregarSalida(new PatronItem("t2", 1));
            U.agregarSalida(new PatronItem("t3", 1));
            U.agregarSalida(new PatronItem("t4", 1));
            U.agregarSalida(new PatronItem("t5", 1));
            U.agregarSalida(new PatronItem("t6", 0));

            V.agregarEntrada(new PatronItem("x1", 1));
            V.agregarEntrada(new PatronItem("x2", 1));
            V.agregarEntrada(new PatronItem("x3", 0));
            V.agregarEntrada(new PatronItem("x4", 0));
            V.agregarEntrada(new PatronItem("x5", 1));
            V.agregarEntrada(new PatronItem("x6", 1));
            V.agregarEntrada(new PatronItem("x7", 1));
            V.agregarEntrada(new PatronItem("x8", 1));
            V.agregarEntrada(new PatronItem("x9", 0));
            V.agregarEntrada(new PatronItem("x10", 0));
            V.agregarEntrada(new PatronItem("x11", 1));
            V.agregarEntrada(new PatronItem("x12", 1));
            V.agregarEntrada(new PatronItem("x13", 1));
            V.agregarEntrada(new PatronItem("x14", 1));
            V.agregarEntrada(new PatronItem("x15", 0));
            V.agregarEntrada(new PatronItem("x16", 0));
            V.agregarEntrada(new PatronItem("x17", 1));
            V.agregarEntrada(new PatronItem("x18", 1));
            V.agregarEntrada(new PatronItem("x19", 1));
            V.agregarEntrada(new PatronItem("x20", 1));
            V.agregarEntrada(new PatronItem("x21", 0));
            V.agregarEntrada(new PatronItem("x22", 0));
            V.agregarEntrada(new PatronItem("x23", 1));
            V.agregarEntrada(new PatronItem("x24", 1));
            V.agregarEntrada(new PatronItem("x25", 0));
            V.agregarEntrada(new PatronItem("x26", 1));
            V.agregarEntrada(new PatronItem("x27", 1));
            V.agregarEntrada(new PatronItem("x28", 1));
            V.agregarEntrada(new PatronItem("x29", 1));
            V.agregarEntrada(new PatronItem("x30", 0));
            V.agregarEntrada(new PatronItem("x31", 0));
            V.agregarEntrada(new PatronItem("x32", 0));
            V.agregarEntrada(new PatronItem("x33", 1));
            V.agregarEntrada(new PatronItem("x34", 1));
            V.agregarEntrada(new PatronItem("x35", 0));
            V.agregarEntrada(new PatronItem("x36", 0));
            V.agregarSalida(new PatronItem("t1", 0));
            V.agregarSalida(new PatronItem("t2", 1));
            V.agregarSalida(new PatronItem("t3", 1));
            V.agregarSalida(new PatronItem("t4", 1));
            V.agregarSalida(new PatronItem("t5", 1));
            V.agregarSalida(new PatronItem("t6", 1));

            W.agregarEntrada(new PatronItem("x1", 1));
            W.agregarEntrada(new PatronItem("x2", 0));
            W.agregarEntrada(new PatronItem("x3", 0));
            W.agregarEntrada(new PatronItem("x4", 0));
            W.agregarEntrada(new PatronItem("x5", 0));
            W.agregarEntrada(new PatronItem("x6", 1));
            W.agregarEntrada(new PatronItem("x7", 1));
            W.agregarEntrada(new PatronItem("x8", 0));
            W.agregarEntrada(new PatronItem("x9", 0));
            W.agregarEntrada(new PatronItem("x10", 0));
            W.agregarEntrada(new PatronItem("x11", 0));
            W.agregarEntrada(new PatronItem("x12", 1));
            W.agregarEntrada(new PatronItem("x13", 1));
            W.agregarEntrada(new PatronItem("x14", 0));
            W.agregarEntrada(new PatronItem("x15", 0));
            W.agregarEntrada(new PatronItem("x16", 0));
            W.agregarEntrada(new PatronItem("x17", 0));
            W.agregarEntrada(new PatronItem("x18", 1));
            W.agregarEntrada(new PatronItem("x19", 1));
            W.agregarEntrada(new PatronItem("x20", 0));
            W.agregarEntrada(new PatronItem("x21", 1));
            W.agregarEntrada(new PatronItem("x22", 1));
            W.agregarEntrada(new PatronItem("x23", 0));
            W.agregarEntrada(new PatronItem("x24", 1));
            W.agregarEntrada(new PatronItem("x25", 1));
            W.agregarEntrada(new PatronItem("x26", 1));
            W.agregarEntrada(new PatronItem("x27", 0));
            W.agregarEntrada(new PatronItem("x28", 0));
            W.agregarEntrada(new PatronItem("x29", 1));
            W.agregarEntrada(new PatronItem("x30", 1));
            W.agregarEntrada(new PatronItem("x31", 1));
            W.agregarEntrada(new PatronItem("x32", 0));
            W.agregarEntrada(new PatronItem("x33", 0));
            W.agregarEntrada(new PatronItem("x34", 0));
            W.agregarEntrada(new PatronItem("x35", 0));
            W.agregarEntrada(new PatronItem("x36", 1));
            W.agregarSalida(new PatronItem("t1", 1));
            W.agregarSalida(new PatronItem("t2", 0));
            W.agregarSalida(new PatronItem("t3", 0));
            W.agregarSalida(new PatronItem("t4", 0));
            W.agregarSalida(new PatronItem("t5", 0));
            W.agregarSalida(new PatronItem("t6", 0));

            X.agregarEntrada(new PatronItem("x1", 1));
            X.agregarEntrada(new PatronItem("x2", 0));
            X.agregarEntrada(new PatronItem("x3", 0));
            X.agregarEntrada(new PatronItem("x4", 0));
            X.agregarEntrada(new PatronItem("x5", 0));
            X.agregarEntrada(new PatronItem("x6", 1));
            X.agregarEntrada(new PatronItem("x7", 0));
            X.agregarEntrada(new PatronItem("x8", 1));
            X.agregarEntrada(new PatronItem("x9", 0));
            X.agregarEntrada(new PatronItem("x10", 0));
            X.agregarEntrada(new PatronItem("x11", 1));
            X.agregarEntrada(new PatronItem("x12", 0));
            X.agregarEntrada(new PatronItem("x13", 0));
            X.agregarEntrada(new PatronItem("x14", 0));
            X.agregarEntrada(new PatronItem("x15", 1));
            X.agregarEntrada(new PatronItem("x16", 1));
            X.agregarEntrada(new PatronItem("x17", 0));
            X.agregarEntrada(new PatronItem("x18", 0));
            X.agregarEntrada(new PatronItem("x19", 0));
            X.agregarEntrada(new PatronItem("x20", 0));
            X.agregarEntrada(new PatronItem("x21", 1));
            X.agregarEntrada(new PatronItem("x22", 1));
            X.agregarEntrada(new PatronItem("x23", 0));
            X.agregarEntrada(new PatronItem("x24", 0));
            X.agregarEntrada(new PatronItem("x25", 0));
            X.agregarEntrada(new PatronItem("x26", 1));
            X.agregarEntrada(new PatronItem("x27", 0));
            X.agregarEntrada(new PatronItem("x28", 0));
            X.agregarEntrada(new PatronItem("x29", 1));
            X.agregarEntrada(new PatronItem("x30", 0));
            X.agregarEntrada(new PatronItem("x31", 1));
            X.agregarEntrada(new PatronItem("x32", 0));
            X.agregarEntrada(new PatronItem("x33", 0));
            X.agregarEntrada(new PatronItem("x34", 0));
            X.agregarEntrada(new PatronItem("x35", 0));
            X.agregarEntrada(new PatronItem("x36", 1));
            X.agregarSalida(new PatronItem("t1", 1));
            X.agregarSalida(new PatronItem("t2", 0));
            X.agregarSalida(new PatronItem("t3", 0));
            X.agregarSalida(new PatronItem("t4", 0));
            X.agregarSalida(new PatronItem("t5", 0));
            X.agregarSalida(new PatronItem("t6", 1));

            Y.agregarEntrada(new PatronItem("x1", 1));
            Y.agregarEntrada(new PatronItem("x2", 0));
            Y.agregarEntrada(new PatronItem("x3", 0));
            Y.agregarEntrada(new PatronItem("x4", 0));
            Y.agregarEntrada(new PatronItem("x5", 0));
            Y.agregarEntrada(new PatronItem("x6", 1));
            Y.agregarEntrada(new PatronItem("x7", 1));
            Y.agregarEntrada(new PatronItem("x8", 1));
            Y.agregarEntrada(new PatronItem("x9", 0));
            Y.agregarEntrada(new PatronItem("x10", 0));
            Y.agregarEntrada(new PatronItem("x11", 1));
            Y.agregarEntrada(new PatronItem("x12", 1));
            Y.agregarEntrada(new PatronItem("x13", 0));
            Y.agregarEntrada(new PatronItem("x14", 1));
            Y.agregarEntrada(new PatronItem("x15", 1));
            Y.agregarEntrada(new PatronItem("x16", 1));
            Y.agregarEntrada(new PatronItem("x17", 1));
            Y.agregarEntrada(new PatronItem("x18", 0));
            Y.agregarEntrada(new PatronItem("x19", 0));
            Y.agregarEntrada(new PatronItem("x20", 0));
            Y.agregarEntrada(new PatronItem("x21", 1));
            Y.agregarEntrada(new PatronItem("x22", 1));
            Y.agregarEntrada(new PatronItem("x23", 0));
            Y.agregarEntrada(new PatronItem("x24", 0));
            Y.agregarEntrada(new PatronItem("x25", 0));
            Y.agregarEntrada(new PatronItem("x26", 0));
            Y.agregarEntrada(new PatronItem("x27", 1));
            Y.agregarEntrada(new PatronItem("x28", 1));
            Y.agregarEntrada(new PatronItem("x29", 0));
            Y.agregarEntrada(new PatronItem("x30", 0));
            Y.agregarEntrada(new PatronItem("x31", 0));
            Y.agregarEntrada(new PatronItem("x32", 0));
            Y.agregarEntrada(new PatronItem("x33", 1));
            Y.agregarEntrada(new PatronItem("x34", 1));
            Y.agregarEntrada(new PatronItem("x35", 0));
            Y.agregarEntrada(new PatronItem("x36", 0));
            Y.agregarSalida(new PatronItem("t1", 1));
            Y.agregarSalida(new PatronItem("t2", 0));
            Y.agregarSalida(new PatronItem("t3", 0));
            Y.agregarSalida(new PatronItem("t4", 0));
            Y.agregarSalida(new PatronItem("t5", 1));
            Y.agregarSalida(new PatronItem("t6", 0));

            Z.agregarEntrada(new PatronItem("x1", 1));
            Z.agregarEntrada(new PatronItem("x2", 1));
            Z.agregarEntrada(new PatronItem("x3", 1));
            Z.agregarEntrada(new PatronItem("x4", 1));
            Z.agregarEntrada(new PatronItem("x5", 1));
            Z.agregarEntrada(new PatronItem("x6", 1));
            Z.agregarEntrada(new PatronItem("x7", 0));
            Z.agregarEntrada(new PatronItem("x8", 0));
            Z.agregarEntrada(new PatronItem("x9", 0));
            Z.agregarEntrada(new PatronItem("x10", 0));
            Z.agregarEntrada(new PatronItem("x11", 1));
            Z.agregarEntrada(new PatronItem("x12", 0));
            Z.agregarEntrada(new PatronItem("x13", 0));
            Z.agregarEntrada(new PatronItem("x14", 0));
            Z.agregarEntrada(new PatronItem("x15", 0));
            Z.agregarEntrada(new PatronItem("x16", 1));
            Z.agregarEntrada(new PatronItem("x17", 0));
            Z.agregarEntrada(new PatronItem("x18", 0));
            Z.agregarEntrada(new PatronItem("x19", 0));
            Z.agregarEntrada(new PatronItem("x20", 0));
            Z.agregarEntrada(new PatronItem("x21", 1));
            Z.agregarEntrada(new PatronItem("x22", 0));
            Z.agregarEntrada(new PatronItem("x23", 0));
            Z.agregarEntrada(new PatronItem("x24", 0));
            Z.agregarEntrada(new PatronItem("x25", 0));
            Z.agregarEntrada(new PatronItem("x26", 1));
            Z.agregarEntrada(new PatronItem("x27", 0));
            Z.agregarEntrada(new PatronItem("x28", 0));
            Z.agregarEntrada(new PatronItem("x29", 0));
            Z.agregarEntrada(new PatronItem("x30", 0));
            Z.agregarEntrada(new PatronItem("x31", 1));
            Z.agregarEntrada(new PatronItem("x32", 1));
            Z.agregarEntrada(new PatronItem("x33", 1));
            Z.agregarEntrada(new PatronItem("x34", 1));
            Z.agregarEntrada(new PatronItem("x35", 1));
            Z.agregarEntrada(new PatronItem("x36", 1));
            Z.agregarSalida(new PatronItem("t1", 1));
            Z.agregarSalida(new PatronItem("t2", 0));
            Z.agregarSalida(new PatronItem("t3", 0));
            Z.agregarSalida(new PatronItem("t4", 0));
            Z.agregarSalida(new PatronItem("t5", 1));
            Z.agregarSalida(new PatronItem("t6", 1));

            Patron[] arrayPatrones = { n0, n1, n2, n3, n4, n5, n6, n7, n8, n9, A, B, C, D, E, F, G, H, I, J, K, L, M,
                                         N, O, P, Q, R, S, T, U, V, W, X, Y, Z };
            backpropagation.patrones = new List<Patron>(arrayPatrones);
        }
    }
}
