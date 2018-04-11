using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trainer.Classes.Padding;


namespace Trainer.Classes
{
    #pragma warning disable CS0169
    public struct GameObject
    {
        private IntPtr a; // 0x0
        private Unknown4 modelInformation; // 0x8 (some sort of information on how the model is rendered)
        private Unknown4 b; // 0xC
        private IntPtr c; // 0x10
        private Unknown8 d; // 0x18
        private float e; // 0x20
        private short f; // 0x24 (some sort of info about animation state)
        public bool CanMove; // 0x26 (movement flag)
        private Unknown1 g; // 0x27
        private Unknown8 h; // 0x28
        private Unknown4 i; // 0x30
        private Unknown4 j; // 0x34 (some sort of movement info)
        private Unknown8 k; // 0x38
        public Point3 Position; // 0x40
        private float l; // 0x4C (empty part of packed float)
        private float orientationW; // 0x50
        private float orientationX; // 0x54
        private float orientationY; // 0x58
        private float orientationZ; // 0x5C
        public Point3 ModelScale; // 0x60
        private float m; // 0x6C (empty part of packed float)
        private Unknown16 n; // 0x70 (packed float which contains info on how model is animated)
        private Unknown16 o; // 0x80 (packed float which contains info on how model is animated)
        private Unknown16 p; // 0x90 (packed float which contains info on how model is animated)
        public Point3 ModelPosition; // 0xA0
        private float q; // 0xAC (empty part of packed float)
        private Unknown16 r; // 0xB0 (duplicate of 0x70)
        private Unknown16 s; // 0xC0 (duplicate of 0x80)
        private Unknown16 t; // 0xD0 (duplicate of 0x90)
        private Unknown16 u; // 0xE0 (duplicate of 0xA0)
        private Unknown1 v; // 0xF0 (some sort of animation info)
        private Unknown1 w; // 0xF1
        private Unknown2 x; // 0xF2
        private Unknown4 y; // 0xF4
        private IntPtr aa; // 0xF8
        private IntPtr ab; // 0x100
        private Unknown2 ac; // 0x108 (some sort of animation state)
        private Unknown2 ad; // 0x10A
        private Unknown4 ae; // 0x10C
        private float af; // 0x110 (some sort of animation state
        private Unknown2 ag; // 0x114
        private Unknown2 ah; // 0x116
        private float ai; // 0x118
        public float AnimationFrames; // 0x11C (state of current animation)
        public float AnimationEnd; // 0x120 (float to play new anim at)
        public float AnimationSpeed; // 0x124
        public float aj; // 0x128 (some sort of animation thing)
        private Unknown4 ak; // 0x12C
        private Unknown16 al; // 0x130
        private Unknown8 am; // 0x140
        private Unknown4 an; // 0x148
        private float ao; // 0x14C (some sort of orientation thing?)
        private Unknown8 ap; // 0x150
        private Unknown4 aq; // 0x158
        private float ar; // 0x15C
        private Unknown8 at; // 0x160
        private Unknown4 au; // 0x168
        private float av; // 0x16C
        private Unknown16 aw; // 0x170
        private Unknown16 ax; // 0x180
        private Unknown16 ay; // 0x190
        private IntPtr az; // 0x1A0
        private Unknown4 bb; // 0x1A8
        private Unknown4 ba; // 0x1AC
        private IntPtr bc; // 0x1B0
        private float bd; // 0x1B8
        private Unknown4 be; // 0x1BC
        private Unknown16 bf; // 0x1C0
        private Unknown16 bg; // 0x1D0
        private IntPtr bh; // 0x1E0
        private IntPtr bi; // 0x1E8
        private Unknown16 bj; // 0x1F0
        private Unknown4 bk; // 0x200
        private float bl; // 0x204
        private Unknown8 bm; // 0x208
        private Unknown8 bn; // 0x210
        private Unknown4 bo; // 0x218
        private float bp; // 0x21C
        private float bq; // 0x220
        private Unknown1 br; // 0x224
        private Unknown1 bs; // 0x225
        private Unknown1 bt; // 0x226
        private Unknown1 bu; // 0x227
        private float bv; // 0x228
        private float bw; // 0x22C
        private Unknown8 bx; // 0x230
        private IntPtr by; // 0x238
        private Unknown4 bz; // 0x240
        private Unknown4 ca; // 0x244
        private float cb; // 0x248
        private Unknown4 cd; // 0x24C
        private IntPtr ce; // 0x250
        private Unknown8 cf; // 0x258
        private float cg; // 0x260 (some sort of animation thing)
        private Unknown4 ch; // 0x264
        private Unknown8 ci; // 0x268
        private Unknown4 cj; // 0x270
        private float ck; // 0x274 (affects animations when landing from jumps)
        private Unknown8 cl; // 0x278
        private Unknown16 cm; // 0x280
        private Unknown16 cn; // 0x290
        private Unknown16 co; // 0x2A0
        private Unknown16 cp; // 0x2B0
        private Unknown16 cq; // 0x2C0
        private Unknown16 cr; // 0x2D0
        private Unknown16 cs; // 0x2E0
        private Unknown16 ct; // 0x2F0
        private Unknown16 cu; // 0x300
        private Unknown16 cv; // 0x310
        private Unknown16 cw; // 0x320
        private Unknown16 cx; // 0x330
        private Unknown16 cy; // 0x340
        private Unknown4 cz; // 0x350
        private float da; // 0x354
        private Unknown4 db; // 0x358
        private Unknown8 dc; // 0x360
        private Unknown4 dd; // 0x368
        private float de; // 0x36C
        private float df; // 0x370
        private Unknown1 dg; // 0x374
        private Unknown1 dh; // 0x375
        private Unknown2 di; // 0x376
        private float dj; // 0x378
        private float dk; // 0x37C
        private Unknown8 dl; // 0x380
        private IntPtr dm; // 0x388
        private Unknown8 dn; // 0x390
        private float dp; // 0x398
        private Unknown4 dq; // 0x39C
        private IntPtr dr; // 0x3A0
        private Unknown4 ds; // 0x3A8
        private Unknown4 dt; // 0x3AC
        private float du; // 0x3B0
        private Unknown4 dv; // 0x3B4
        private Unknown4 dw; // 0x3B8
        private Unknown4 dx; // 0x3BC
        private Unknown4 dy; // 0x3C0
        private float dz; // 0x3C4
        private Unknown8 ea; // 0x3C8
        private Unknown16 eb; // 0x3D0
        private Unknown16 ec; // 0x3E0
        private Unknown16 ed; // 0x3F0
        private Unknown16 ee; // 0x400
        private Unknown16 ef; // 0x410
        private Unknown16 eg; // 0x420
        private Unknown16 eh; // 0x430
        private Unknown16 ei; // 0x440
        private Unknown16 ej; // 0x450
        private Unknown16 ek; // 0x460
        private Unknown16 el; // 0x470
        private Unknown16 em; // 0x480
        private Unknown16 en; // 0x490
        private Unknown16 eo; // 0x4A0
        private Unknown16 ep; // 0x4B0
        private Unknown16 eq; // 0x4C0
        private Unknown16 er; // 0x4D0
        private Unknown16 es; // 0x4E0
        private Unknown16 et; // 0x4F0
        private Unknown16 eu; // 0x500
        private Unknown16 ev; // 0x510
        private Unknown16 ew; // 0x520
        private Unknown16 ex; // 0x530
        private Unknown16 ey; // 0x540
        private Unknown16 ez; // 0x550
        private Unknown16 fa; // 0x560
        private Unknown16 fb; // 0x570
        private Unknown16 fc; // 0x580
        private Unknown16 fd; // 0x590
        private Unknown16 fe; // 0x5A0
        private Unknown16 ff; // 0x5B0
        private Unknown16 fg; // 0x5C0
        private Unknown16 fh; // 0x5D0
        private Unknown16 fi; // 0x5E0
        private Unknown16 fj; // 0x5F0
        private Unknown16 fk; // 0x600
        private Unknown16 fl; // 0x610
        private Unknown16 fm; // 0x620
        private Unknown16 fn; // 0x630
        private Unknown16 fo; // 0x640
        private Unknown16 fp; // 0x650
        private Unknown16 fq; // 0x660
        private Unknown16 fr; // 0x670
        private Unknown16 fs; // 0x680
        private Unknown16 ft; // 0x690
        private Unknown16 fu; // 0x6A0
        private Unknown16 fv; // 0x6B0
        private Unknown16 fw; // 0x6C0
        private Unknown16 fx; // 0x6D0
        private Unknown16 fy; // 0x6E0
        private Unknown16 fz; // 0x6F0
        private Unknown16 ga; // 0x700
        private Unknown16 gb; // 0x710
        private Unknown16 gc; // 0x720
        private Unknown16 gd; // 0x730
        private Unknown16 ge; // 0x740
        private Unknown16 gf; // 0x750
        private Unknown16 gg; // 0x760
        private Unknown16 gh; // 0x770
        private Unknown16 gi; // 0x780
        private Unknown16 gj; // 0x790
        private Unknown16 gk; // 0x7A0
        private Unknown16 gl; // 0x7B0
        private Unknown16 gm; // 0x7C0
        private Unknown16 gn; // 0x7D0
        private Unknown16 go; // 0x7E0
        private Unknown16 gp; // 0x7F0
        private Unknown16 gq; // 0x800
        private Unknown16 gr; // 0x810
        private Unknown16 gs; // 0x820
        private Unknown16 gt; // 0x830
        private Unknown16 gu; // 0x840
        private Unknown16 gv; // 0x850
        private Unknown16 gw; // 0x860
        private Unknown16 gx; // 0x870
        private Unknown16 gy; // 0x880
        private Unknown16 gz; // 0x890
        private Unknown16 ha; // 0x8A0
        private Unknown16 hb; // 0x8B0
        private Unknown16 hc; // 0x8C0
        private Unknown16 hd; // 0x8D0
        private Unknown16 he; // 0x8E0
        private Unknown16 hf; // 0x8F0
        private Unknown16 hg; // 0x900
        private Unknown16 hh; // 0x910
        private Unknown16 hi; // 0x920
        private Unknown16 hj; // 0x930
        private Unknown16 hk; // 0x940
        private Unknown16 hl; // 0x950
        private Unknown16 hm; // 0x960
        private Unknown16 hn; // 0x970
        private Unknown16 ho; // 0x980
        private Unknown16 hp; // 0x990
        private Unknown16 hq; // 0x9A0
        private Unknown16 hr; // 0x9B0
        private Unknown16 hs; // 0x9C0
        private Unknown16 ht; // 0x9D0
        private Unknown16 hu; // 0x9E0
        private Unknown16 hv; // 0x9F0
        private Unknown16 hw; // 0xA00
        private Unknown16 hx; // 0xA10
        private Unknown16 hy; // 0xA20
        private Unknown16 hz; // 0xA30
        private Unknown16 ia; // 0xA40
        private Unknown16 ib; // 0xA50
        private Unknown16 ic; // 0xA60
        private Unknown16 id; // 0xA70
        private Unknown16 ie; // 0xA80
        private Unknown16 ig; // 0xA90
        private Unknown16 ih; // 0xAA0
        private Unknown16 ii; // 0xAB0
        private Unknown16 ij; // 0xAC0
        private Unknown16 ik; // 0xAD0
        private Unknown16 il; // 0xAE0
        private Unknown16 im; // 0xAF0
        private Unknown16 io; // 0xB00
        private Unknown16 ip; // 0xB10
        private Unknown16 iq; // 0xB20
        private Unknown16 ir; // 0xB30
        private Unknown16 it; // 0xB40
        private Unknown16 iu; // 0xB50
        private Unknown16 iv; // 0xB60
        private Unknown16 iw; // 0xB70
        private float ix; // 0xB80
        private float iy; // 0xB84
        private float iz; // 0xB88
        private float ja; // 0xB8C
        private float jb; // 0xB90
        private float jc; // 0xB94
        private float jd; // 0xB98
        private float je; // 0xB9C
        private float jf; // 0xBA0
        private float jg; // 0xBA4
        private float jh; // 0xBA8
        private float ji; // 0xBAC
        private float jj; // 0xBB0
        private float jk; // 0xBB4
        private float jl; // 0xBB8
        private float jm; // 0xBBC
        private Unknown4 jn; // 0xBC0
        private Unknown4 jo; // 0xBC4
        private Unknown4 jp; // 0xBC8
        private Unknown4 jq; // 0xBCC
        private Unknown16 jr; // 0xBD0
        private Unknown16 js; // 0xBE0
        private Unknown16 jt; // 0xBF0
        private Unknown4 ju; // 0xC00
        private Unknown4 jv; // 0xC04
        private Unknown4 jw; // 0xC08
        private Unknown4 jx; // 0xC0C
        private IntPtr jy; // 0xC10
        private Unknown4 jz; // 0xC18
        private Unknown4 ka; // 0xC1C
        private Unknown4 kb; // 0xC20
        private Unknown4 kc; // 0xC24
        private float kd; // 0xC28
        private Unknown4 ke; // 0xC2C
        private Unknown16 kf; // 0xC30
        private Unknown16 kg; // 0xC40
        private Unknown16 kh; // 0xC50
        private float ki; // 0xC60 (packed float that has something to do with model)
        private float kj; // 0xC64
        private float kk; // 0xC68
        private float kl; // 0xC6C
        private Unknown16 km; // 0xC70
        private Unknown8 kn; // 0xC80
        private Unknown4 ko; // 0xC88
        private float kp; // 0xC8C
        private IntPtr kq; // 0xC90
        private IntPtr kr; // 0xC98
        private IntPtr ks; // 0xCA0
        private IntPtr kt; // 0xCA8
        private IntPtr ku; // 0xCB0
        private IntPtr kv; // 0xCB8
        private IntPtr kw; // 0xCC0
        private IntPtr kx; // 0xCC8
        private IntPtr ky; // 0xCD0
        private IntPtr kz; // 0xCD8
        private Unknown16 la; // 0xCE0
        private Unknown16 lb; // 0xCF0
        private Unknown16 lc; // 0xD00
        private Unknown16 ld; // 0xD10
        private Unknown16 le; // 0xD20
        private float lf; // 0xD30
        private float lg; // 0xD34
        private float lh; // 0xD38
        private Unknown4 li; // 0xD3C
        private Unknown16 lj; // 0xD40
        private Unknown16 lk; // 0xD50
        private Unknown8 ll; // 0xD60
        private IntPtr lm; // 0xD68
        private IntPtr ln; // 0xD70
        private IntPtr lo; // 0xD78
        private Unknown16 lp; // 0xD80
        private Unknown16 lq; // 0xD90
        private Unknown16 lr; // 0xDA0
        private Unknown16 ls; // 0xDB0
        private IntPtr lt; // 0xDC0
        private IntPtr lu; // 0xDC8
        private Unknown16 lv; // 0xDE0
        private IntPtr lw; // 0xDF0
        private Unknown8 lx; // 0xDF8
        private Unknown8 ly; // 0xE00
        private IntPtr lz; // 0xE08
        private Unknown16 ma; // 0xE10
        private IntPtr mb; // 0xE20
        private Unknown8 mc; // 0xE28
        private Unknown16 md; // 0xE30
        private Unknown16 me; // 0xE40
        private Unknown16 mf; // 0xE50
        private Unknown16 mg; // 0xE60
        private Unknown16 mh; // 0xE70
        private Unknown16 mi; // 0xE80
        private Unknown16 mj; // 0xE90
        private Unknown16 mk; // 0xEA0
        private Unknown16 ml; // 0xEB0
        private Unknown16 mm; // 0xEC0
        private Unknown16 mn; // 0xED0
        private Unknown16 mo; // 0xEE0
        private Unknown16 mp; // 0xEF0
        private Unknown16 mq; // 0xF00
        private Unknown16 mr; // 0xF10
        private Unknown16 ms; // 0xF20
        private Unknown16 mt; // 0xF30
        private Unknown16 mu; // 0xF40
        private Unknown16 mv; // 0xF50
        private Unknown16 mw; // 0xF60
        private Unknown16 mx; // 0xF70
        private Unknown16 my; // 0xF80
        private Unknown16 mz; // 0xF90
        private Unknown16 na; // 0xFA0
        private Unknown16 nb; // 0xFB0
        private Unknown16 nc; // 0xFC0
        private Unknown16 nd; // 0xFD0
        private Unknown16 ne; // 0xFE0
        private Unknown8 ng; // 0xFF0
        private Unknown4 nh; // 0xFF8
        private float ni; // 0xFFC
        private Point3 nj; // 0x1000
        private float nk; // 0x100C
        private Unknown16 nl; // 0x1010
        private Unknown16 nm; // 0x1020
        private Unknown16 nn; // 0x1030
        private Unknown16 no; // 0x1040
        private Unknown16 np; // 0x1050
        private Unknown16 nq; // 0x1060
        private Unknown16 nr; // 0x1070
        private Unknown16 ns; // 0x1080
        private IntPtr nt; // 0x1090
        private IntPtr nu; // 0x1098
        private Unknown16 nv; // 0x10A0
        private Unknown16 nw; // 0x10B0
        private Unknown8 nx; // 0x10C0
        private IntPtr ny; // 0x10C8
        private IntPtr nz; // 0x10D0
        private Unknown8 oa; // 0x10D8
        private Unknown16 ob; // 0x10E0
        private Unknown16 oc; // 0x10F0
        private Unknown16 od; // 0x1100
        private IntPtr oe; // 0x1110
        private Unknown8 of; // 0x1118
        private Unknown16 og; // 0x1120
        private Unknown16 oh; // 0x1130
        private Unknown16 oi; // 0x1140
        private Unknown16 oj; // 0x1150
        private Unknown16 ok; // 0x1160
        private Unknown8 ol; // 0x1170
        private Unknown8 om; // 0x1178
        private Unknown16 on; // 0x1180
        private Unknown16 oo; // 0x1190
        private Unknown8 op; // 0x11A0
        private float oq; // 0x11A8
        private float or; // 0x11AC
        private float os; // 0x11B0
        private float ot; // 0x11B4
        private float ou; // 0x11B8
        private float ov; // 0x11BC
        private float ow; // 0x11C0
        private float ox; // 0x11C4
        private float oy; // 0x11C8
        private float oz; // 0x11CC
        private float pa; // 0x11D0
        private float pb; // 0x11D4
        private Unknown8 pc; // 0x11D8
        private Unknown16 pd; // 0x11E0
        private Unknown16 pe; // 0x11F0
        private Unknown16 pf; // 0x1200
        private Unknown16 pg; // 0x1210
        private IntPtr ph; // 0x1220
        private Unknown8 pi; // 0x1228
        public Ref<GameObject> EquippedItem; // 0x1230
        private IntPtr pk; // 0x1238
        private Unknown16 pl; // 0x1240
        private Unknown16 pm; // 0x1250
        private Unknown16 pn; // 0x1260
        private Unknown16 po; // 0x1270
        private Unknown16 pp; // 0x1280
        private Unknown16 pq; // 0x1290
        private Unknown16 pr; // 0x12A0
        private Unknown16 ps; // 0x12B0
        private Unknown16 pt; // 0x12C0
        private Unknown16 pu; // 0x12D0
        private Unknown4 pv; // 0x12E0
        private int pw; // 0x12E4
        public int MaxHealth; // 0x12E8
        public int Health; // 0x12EC

        // TODO

        public int HealthBarStringIdx; // 0x1D68 (used for string displayed in green HP bar)

        // TODO

        public int ItemNameStringIdx; // 0x36FC

        // TODO

        public bool AimModelSkew; // 0x3722

        // TODO

        public bool ModelVisible; // 0x3726
    }
    #pragma warning restore CS0169
}
