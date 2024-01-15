
import RankItemsContainer from "./components/RankItemsContainer";
import FootballImageArr from "./components/FootballImages.js";

const AppRoutes = [
  {
        index: true,
        element: <RankItemsContainer dataType={1} imgArr={FootballImageArr} />
  },
    {
        path: '/rank-items',
        element: <RankItemsContainer dataType={1} imgArr={FootballImageArr} />
  }
];

export default AppRoutes;
