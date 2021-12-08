html {
    color: azure;
    background: #0E0F19;
}

.info {
    background: #466060;
    margin: 2em 0 0 0;
    padding: 1em;
}

.panel {
    background: #466060;
    display: flex;
    justify-content: center;
    margin: 2em 0 0 0;
}

    .panel form {
        padding-top: 1em;
        padding-bottom: 1em;
        margin: 1em;
    }

        .panel form input {
            border-radius: 5px;
        }

            .panel form input[type="text"] {
                padding: 0.5em 0.5em 0.5em 0.5em;
            }

            .panel form input[type="password"] {
                padding: 0.5em 0.5em 0.5em 0.5em;
            }

            .panel form input[type="submit"], .panel form button {
                background: #F8C7CC;
                border-radius: 50px;
                border: 1px white;
                padding: 1em 1em 1em 1em;
            }

.header {
    background: #57886C;
    align-items: center;
    height: 5em;
}

    .header h2 {
        display: inline;
        margin-left: 1em;
        line-height: 3.4em;
    }

    .header ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        overflow: hidden;
    }

    .header li {
        float: left;
    }

        .header li a {
            display: inline-block;
            width: 50px;
            border-radius: 50px;
            padding: 1em;
            margin: 1em 1em 1em 1em;
            background: #81A684;
            color: azure;
            text-decoration: none;
        }
