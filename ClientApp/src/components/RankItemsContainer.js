import { useState } from 'react';
import RankItems from './RankItems';

const RankItemsContainer = ({ dataType, imgArr }) => {
    const footballLocalStorageKey = "movies";

    var localStorageKey = "";

    const [footballItems, setFootballItems] = useState(JSON.parse(localStorage.getItem(footballLocalStorageKey)));



    var data = [];
    var setFunc = null;

    if (dataType === 1) {
        data = footballItems;
        setFunc = setFootballItems;
        localStorageKey = footballLocalStorageKey;

    }

    return (
        <RankItems items={data} setItems={setFunc} dataType={dataType} imgArr={imgArr} localStorageKey={localStorageKey} />
    )


}
export default RankItemsContainer;