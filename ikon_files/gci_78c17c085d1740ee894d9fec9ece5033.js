(function(){try{var d=null;window.gbar.tev&&window.gbar.tev(3,"gc");var h=this,i=function(a){a=a.split(".");for(var b=h,c;c=a.shift();)if(b[c]!=d)b=b[c];else return d;return b},j=function(a){return a.call.apply(a.bind,arguments)},n=function(a,b){if(!a)throw Error();if(arguments.length>2){var c=Array.prototype.slice.call(arguments,2);return function(){var e=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(e,c);return a.apply(b,e)}}else return function(){return a.apply(b,arguments)}},o=function(){o=Function.prototype.bind&&Function.prototype.bind.toString().indexOf("native code")!=
-1?j:n;return o.apply(d,arguments)};var q={u:1,z:2,Q:3,p:4,L:5,C:6,v:7,D:8,U:9,K:10,B:11,J:12,I:13,F:14,H:15,g:16,S:17,s:18,G:19,T:20,R:21,r:22,w:23,W:24,X:25,V:26,t:27,h:28,k:29,j:30,P:31,M:32,N:33,A:500,O:501};var r=window.gbar;var u={a:1,o:2,n:3,d:4,c:5,f:6,e:7,b:8};var v=[],w=d,x=function(a,b){var c=d;if(b)c={m:b};r.tev&&r.tev(a,"gc",c)},B=function(){x(u.d);var a,b;for(a=0;b=r.bnc[a];++a)if(b[0]=="gc")break;if(b&&!b[1].l){a=function(){for(var c=r.mdc,e=r.mdi||{},g=0,k;k=v[g];++g){var l=k[0],s=c[l],m=e[l],f;if(f=s){if(m=!m){var p;a:{m=l;if(f=r.mdd)try{if(!w){w={};var t=f.split(/;/);for(f=0;f<t.length;++f)w[t[f]]=true}p=w[m];break a}catch(y){r.logger&&r.logger.ml(y)}p=false}m=!p}f=m}if(f){x(u.f,l);try{k[1].init(s);e[l]=true}catch(z){r.logger&&r.logger.ml(z)}x(u.e,
l)}}if(c=r.qd.gc){r.qd.gc=[];for(e=0;g=c[e];++e)try{g()}catch(A){r.logger&&r.logger.ml(A)}}b[1].l=true;x(u.c);a:{for(c=0;e=r.bnc[c];++c)if((e[1].auto||e[0]=="m")&&!e[1].l){c=false;break a}c=true}c&&x(u.a)};if(!b[1].libs||r.agl&&r.agl(b[1].libs))a();else b[1].i=a}};v.push(["gc",{init:function(a){var b=i("gbar.logger.il");window.gadgets.config.update({"googleapis.config":{gcv:a.version,sessionIndex:a.index,elog:function(c,e){var g=i("gbar.logger.ml");if(g){var k=e||{};k._sn="gc";g(c,k)}},ilog:b&&o(b,d,q.g)}});window.gapi.config.update({gwidget:{lang:a.lang}})}}]);x(u.b);window.gbar&&window.gbar.bnc&&B();}catch(e){window.gbar&&gbar.logger&&gbar.logger.ml(e,{"_sn":"gc.init"});}})();
