
let create_child=(tag_child,class_child='',root)=>{
    let child=document.createElement(tag_child);
    child.className=class_child; 
    root.append(child);
    return child;
    
}
let fill_sidebar=(e)=>{

    let id=e.target.getAttribute('id');
    let topBar=document.getElementById('top-bar');
    let bottomBar=document.getElementById('bottom-bar');

    topBar.innerHTML='';
    bottomBar.innerHTML='';
    

    sidebar_["top-bar"][id].forEach((el)=>{
       
        let child=create_child('p','',topBar);

        child.style.margin='15px 0';
        child.innerHTML=el;
        
    });

    Object.entries(sidebar_["bottom-bar"]).forEach(([key, value]) => {
            
        let div_grid=create_child('div','',bottomBar);
        let div_left=create_child('div','',div_grid);
        let div_right=create_child('div','',div_grid);
        
        div_left.innerHTML=key;
        div_right.innerHTML=value;

        div_grid.style.display='grid';
        div_grid.style.gridTemplateColumns='1fr 1fr';
        
    });
}

let fill_content=(e)=>{
    let id=e.target.getAttribute('id');
    let data=content_[id];
    let content=document.getElementById('content');

    content.innerHTML='';

    data.forEach((arr)=>{
        let root=create_child('div','',content);
        let cols='';
        
        arr.forEach((el)=>{
            let child=create_child('div','',root);
            child.innerHTML=el;
            cols+=' 1fr'
        });
        
        root.style.display='grid';
        root.style.gridTemplateColumns=cols;
        root.style.padding='10px 0 5px 10px';
    });
}




document.querySelectorAll('nav button').forEach((el)=>{
    el.addEventListener("click", (e)=>{
        document.querySelector('.active').classList.remove('active');
        e.target.className='active';
    });
});

document.getElementById('main').click();