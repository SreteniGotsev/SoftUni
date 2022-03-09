class ArtGallery{
    constructor(creator){
        this. creator = creator; 
        possibleArticles = { "picture" : 200,"photo" : 50,"item" : 250 }
        listOfArticles  = []
        guests =  []
    }

    addArticle( articleModel, articleName, quantity ){

        if(possibleArticles.Includes(articleModel.toLowerCase()))
        {
            throw Error("This article model is not included in this gallery!")
        }

        return "Successfully added article {articleName} with a new quantity- {quantity}."
    }

    inviteGuest ( guestName, personality)
    buyArticle ( articleModel, articleName, guestName)
    showGalleryInfo (criteria)
}

let artGallery = new ArtGallery('Curtis Mayfield'); 
artGallery.addArticle('picture', 'Mona Liza', 3);
